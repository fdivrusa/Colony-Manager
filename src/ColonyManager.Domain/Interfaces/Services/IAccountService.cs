using ColonyManager.Domain.Models.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        Task<AuthenticateResponseDto> AuthenticateAsync(AuthenticateRequestDto request, string ipv4Address, string ipv6Address);
        Task<AuthenticateResponseDto> RefreshTokenAsync(string token, string ipv4Address, string ipv6Address);
        Task RevokeToken(string token, string ipv4Address, string ipv6Address);
        Task Register(RegisterRequestDto request, string origin);
        Task VerifyEmailAsync(string token);
        Task ForgotPasswordAsync(ForgotPasswordRequestDto request, string origin);
        Task ValidateResetTokenAsync(ValidateResetTokenRequestDto request);

        /// <summary>
        /// Reset password
        /// </summary>
        /// <param name="request"></param>
        Task ResetPasswordAsync(ResetPasswordRequestDto request);

        IEnumerable<AccountResponseDto> GetAll();
        Task<AccountResponseDto> GetByIdAsync(int id);
        Task<AccountResponseDto> CreateAsync(CreateAccountRequestDto request);
        Task<AccountResponseDto> UpdateAsync(int id, UpdateRequestDto request);
        Task DeleteAsync(int id);
    }
}
