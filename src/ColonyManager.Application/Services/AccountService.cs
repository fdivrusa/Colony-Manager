using AutoMapper;
using ColonyManager.Core;
using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models.Account;
using FluentValidation;
using BC = BCrypt.Net.BCrypt;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Collections.Generic;
using System.Security.Claims;

namespace ColonyManager.Application.Services
{
    public class AccountService : IAccountService
    {

        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;
        private readonly ColonyManagerDbContext _dbContext;
        private readonly IEmailService _emailService;
        private readonly IValidator<AuthenticateRequestDto> _authenticateRequestValidator;
        private readonly IValidator<ForgotPasswordRequestDto> _forgotPasswordRequestValidator;
        private readonly IValidator<RegisterRequestDto> _registerRequestValidator;
        private readonly IValidator<CreateAccountRequestDto> _createAccountRequestValidator;
        private readonly IValidator<UpdateRequestDto> _updateRequestValidator;

        public AccountService(IMapper mapper,
            IOptions<AppSettings> appSettings,
            ColonyManagerDbContext dbContext,
            IEmailService emailService,
            IValidator<AuthenticateRequestDto> authenticateRequestValidator,
            IValidator<ForgotPasswordRequestDto> forgotPasswordRequestValidator,
            IValidator<RegisterRequestDto> registerRequestValidator,
            IValidator<CreateAccountRequestDto> createAccountRequestValidator,
            IValidator<UpdateRequestDto> updateRequestValidator)
        {
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _dbContext = dbContext;
            _emailService = emailService;
            _authenticateRequestValidator = authenticateRequestValidator;
            _forgotPasswordRequestValidator = forgotPasswordRequestValidator;
            _registerRequestValidator = registerRequestValidator;
            _createAccountRequestValidator = createAccountRequestValidator;
            _updateRequestValidator = updateRequestValidator;
        }

        public async Task<AuthenticateResponseDto> AuthenticateAsync(AuthenticateRequestDto request, string ipv4Address, string ipv6Address)
        {
            await _authenticateRequestValidator.ValidateAndThrowAsync(request);

            var account = _dbContext.Accounts.SingleOrDefault(x => x.Email == request.Email);

            if (account == null || !account.IsVerified || !BC.Verify(request.Password, account.PasswordHash))
                throw new AppException("Email or password is incorrect");

            // authentication successful so generate jwt and refresh tokens
            var jwtToken = GenerateJwtToken(account);
            var refreshToken = GenerateRefreshToken(ipv4Address, ipv6Address);
            account.RefreshTokens.Add(refreshToken);

            // remove old refresh tokens from account
            RemoveOldRefreshTokens(account);

            // save changes to db
            _dbContext.Update(account);
            await _dbContext.SaveChangesAsync();

            var response = _mapper.Map<AuthenticateResponseDto>(account);
            response.JwtToken = jwtToken;
            response.RefreshToken = refreshToken.Token;
            return response;

        }

        public async Task<AuthenticateResponseDto> RefreshTokenAsync(string token, string ipv4Address, string ipv6Address)
        {
            var (refreshToken, account) = GetRefreshToken(token);

            // replace old refresh token with a new one and save
            var newRefreshToken = GenerateRefreshToken(ipv4Address, ipv6Address);
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIpv4 = ipv4Address;
            refreshToken.RevokedByIpv6 = ipv6Address;
            refreshToken.ReplacedByToken = newRefreshToken.Token;
            account.RefreshTokens.Add(newRefreshToken);

            RemoveOldRefreshTokens(account);

            _dbContext.Update(account);
            await _dbContext.SaveChangesAsync();

            // generate new jwt
            var jwtToken = GenerateJwtToken(account);

            var response = _mapper.Map<AuthenticateResponseDto>(account);
            response.JwtToken = jwtToken;
            response.RefreshToken = newRefreshToken.Token;
            return response;
        }

        public async Task ForgotPasswordAsync(ForgotPasswordRequestDto request, string origin)
        {
            await _forgotPasswordRequestValidator.ValidateAndThrowAsync(request);

            var account = _dbContext.Accounts.SingleOrDefault(x => x.Email == request.Email);

            if (account == null)
            {
                return;
            }

            // create reset token that expires after 1 day
            account.ResetToken = RandomTokenString();
            account.ResetTokenExpires = DateTime.UtcNow.AddDays(1);

            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();

            // send email
            SendPasswordResetEmail(account, origin);
        }

        public async Task Register(RegisterRequestDto request, string origin)
        {
            await _registerRequestValidator.ValidateAndThrowAsync(request);

            // validate
            if (_dbContext.Accounts.Any(x => x.Email == request.Email))
            {
                // send already registered error in email to prevent account enumeration
                SendAlreadyRegisteredEmail(request.Email, origin);
                return;
            }

            // map model to new account object
            var account = _mapper.Map<Account>(request);

            // first registered account is an admin
            var isFirstAccount = _dbContext.Accounts.Count() == 0;
            account.Role = isFirstAccount ? Role.Admin : Role.User;
            account.CreatedDate = DateTime.UtcNow;
            account.VerificationToken = RandomTokenString();

            // hash password
            account.PasswordHash = BC.HashPassword(request.Password);

            // save account
            _dbContext.Accounts.Add(account);
            await _dbContext.SaveChangesAsync();

            // send email
            SendVerificationEmail(account, origin);
        }

        public async Task ResetPasswordAsync(ResetPasswordRequestDto request)
        {
            var account = _dbContext.Accounts.SingleOrDefault(x => x.ResetToken == request.Token && x.ResetTokenExpires > DateTime.UtcNow);

            if (account == null)
                throw new AppException("Invalid token");

            // update password and remove reset token
            account.PasswordHash = BC.HashPassword(request.Password);
            account.PasswordReset = DateTime.UtcNow;
            account.ResetToken = null;
            account.ResetTokenExpires = null;

            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RevokeToken(string token, string ipv4Address, string ipv6Address)
        {
            var (refreshToken, account) = GetRefreshToken(token);

            // revoke token and save
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIpv4 = ipv4Address;
            refreshToken.RevokedByIpv6 = ipv6Address;
            _dbContext.Update(account);
            await _dbContext.SaveChangesAsync();
        }

        public void ValidateResetToken(ValidateResetTokenRequestDto model)
        {

            var account = _dbContext.Accounts.SingleOrDefault(x => x.ResetToken == model.Token && x.ResetTokenExpires > DateTime.UtcNow);

            if (account == null)
                throw new AppException("Invalid token");
        }

        public async Task VerifyEmailAsync(string token)
        {
            var account = _dbContext.Accounts.SingleOrDefault(x => x.VerificationToken == token);

            if (account == null) throw new AppException("Verification failed");

            account.Verified = DateTime.UtcNow;
            account.VerificationToken = null;

            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();
        }

        Task IAccountService.ValidateResetTokenAsync(ValidateResetTokenRequestDto request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountResponseDto> GetAll()
        {
            return _mapper.Map<IList<AccountResponseDto>>(_dbContext.Accounts);
        }

        public async Task<AccountResponseDto> GetByIdAsync(int id)
        {
            var account = await GetAccount(id);
            return _mapper.Map<AccountResponseDto>(account);
        }

        public async Task<AccountResponseDto> CreateAsync(CreateAccountRequestDto request)
        {

            await _createAccountRequestValidator.ValidateAndThrowAsync(request);

            // validate
            if (_dbContext.Accounts.Any(x => x.Email == request.Email))
                throw new AppException($"Email '{request.Email}' is already registered");

            // map model to new account object
            var account = _mapper.Map<Account>(request);
            account.CreatedDate = DateTime.UtcNow;
            account.Verified = DateTime.UtcNow;

            // hash password
            account.PasswordHash = BC.HashPassword(request.Password);

            // save account
            _dbContext.Accounts.Add(account);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<AccountResponseDto>(account);
        }

        public async Task<AccountResponseDto> UpdateAsync(int id, UpdateRequestDto request)
        {
            await _updateRequestValidator.ValidateAndThrowAsync(request);

            var account = await GetAccount(id);

            // validate
            if (account.Email != request.Email && _dbContext.Accounts.Any(x => x.Email == request.Email))
                throw new AppException($"Email '{request.Email}' is already taken");

            // hash password if it was entered
            if (!string.IsNullOrEmpty(request.Password))
                account.PasswordHash = BC.HashPassword(request.Password);

            // copy model to account and save
            _mapper.Map(request, account);
            account.UpdatedDate = DateTime.UtcNow;
            _dbContext.Accounts.Update(account);
            await _dbContext.SaveChangesAsync();

            return _mapper.Map<AccountResponseDto>(account);
        }

        public async Task DeleteAsync(int id)
        {
            var account = await GetAccount(id);
            _dbContext.Accounts.Remove(account);
            await _dbContext.SaveChangesAsync();
        }

        #region Private methods
        private (RefreshToken, Account) GetRefreshToken(string token)
        {
            var account = _dbContext.Accounts.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));
            if (account == null) throw new AppException("Invalid token");
            var refreshToken = account.RefreshTokens.Single(x => x.Token == token);
            if (!refreshToken.IsActive) throw new AppException("Invalid token");
            return (refreshToken, account);
        }

        private string GenerateJwtToken(Account account)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("Id", account.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private RefreshToken GenerateRefreshToken(string ipv4, string ipv6)
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                ExpirationDate = DateTime.UtcNow.AddDays(7),
                CreatedDate = DateTime.UtcNow,
                CreatedByIpv4 = ipv4,
                CreatedByIpv6 = ipv6
            };
        }

        private void RemoveOldRefreshTokens(Account account)
        {
            account.RefreshTokens.RemoveAll(x =>
                !x.IsActive &&
                x.CreatedDate.AddDays(_appSettings.RefreshTokenTTL) <= DateTime.UtcNow);
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        private void SendVerificationEmail(Account account, string origin)
        {
            string message;
            if (!string.IsNullOrEmpty(origin))
            {
                var verifyUrl = $"{origin}/account/verify-email?token={account.VerificationToken}";
                message = $@"<p>Please click the below link to verify your email address:</p>
                             <p><a href=""{verifyUrl}"">{verifyUrl}</a></p>";
            }
            else
            {
                message = $@"<p>Please use the below token to verify your email address with the <code>/accounts/verify-email</code> api route:</p>
                             <p><code>{account.VerificationToken}</code></p>";
            }

            _emailService.Send(
                to: account.Email,
                subject: "Sign-up Verification API - Verify Email",
                html: $@"<h4>Verify Email</h4>
                         <p>Thanks for registering!</p>
                         {message}"
            );
        }

        private void SendAlreadyRegisteredEmail(string email, string origin)
        {
            string message;
            if (!string.IsNullOrEmpty(origin))
                message = $@"<p>If you don't know your password please visit the <a href=""{origin}/account/forgot-password"">forgot password</a> page.</p>";
            else
                message = "<p>If you don't know your password you can reset it via the <code>/accounts/forgot-password</code> api route.</p>";

            _emailService.Send(
                to: email,
                subject: "Sign-up Verification API - Email Already Registered",
                html: $@"<h4>Email Already Registered</h4>
                         <p>Your email <strong>{email}</strong> is already registered.</p>
                         {message}"
            );
        }

        private void SendPasswordResetEmail(Account account, string origin)
        {
            string message;
            if (!string.IsNullOrEmpty(origin))
            {
                var resetUrl = $"{origin}/account/reset-password?token={account.ResetToken}";
                message = $@"<p>Please click the below link to reset your password, the link will be valid for 1 day:</p>
                             <p><a href=""{resetUrl}"">{resetUrl}</a></p>";
            }
            else
            {
                message = $@"<p>Please use the below token to reset your password with the <code>/accounts/reset-password</code> api route:</p>
                             <p><code>{account.ResetToken}</code></p>";
            }

            _emailService.Send(
                to: account.Email,
                subject: "Sign-up Verification API - Reset Password",
                html: $@"<h4>Reset Password Email</h4>
                         {message}"
            );
        }

        private async Task<Account> GetAccount(int id)
        {
            var account = await _dbContext.Accounts.FindAsync(id);
            if (account == null) throw new KeyNotFoundException("Account not found");
            return account;
        }
        #endregion
    }
}
