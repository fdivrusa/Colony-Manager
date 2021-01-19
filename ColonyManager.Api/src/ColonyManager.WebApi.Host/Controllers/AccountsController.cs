using AutoMapper;
using ColonyManager.Core;
using ColonyManager.Data;
using ColonyManager.Data.Entities;
using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models.Account;
using ColonyManager.Utility.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : BaseController
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountsController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpPost("authenticate")]
        public async Task<ActionResult<AuthenticateResponseDto>> AuthenticateAsync(AuthenticateRequestDto model)
        {
            var response = await _accountService.AuthenticateAsync(model, GetIpv4Address(), GetIpv6Address());
            SetTokenCookie(response.RefreshToken);
            return Ok(response);
        }

        [HttpPost("refresh-token")]
        public async Task<ActionResult<AuthenticateResponseDto>> RefreshTokenAsync()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            var response = await _accountService.RefreshTokenAsync(refreshToken, GetIpv4Address(), GetIpv6Address());
            SetTokenCookie(response.RefreshToken);
            return Ok(response);
        }


        [Authorize(Role.Admin)]
        [HttpPost("revoke-token")]
        public IActionResult RevokeToken(RevokeTokenRequestDto request)
        {
            // accept token from request body or cookie
            var token = request.Token ?? Request.Cookies["refreshToken"];

            if (string.IsNullOrEmpty(token))
                return BadRequest(new { message = "Token is required" });

            // users can revoke their own tokens and admins can revoke any tokens
            if (!Account.OwnsToken(token) && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            _accountService.RevokeToken(token, GetIpv4Address(), GetIpv6Address());
            return Ok(new { message = "Token revoked" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequestDto request)
        {
            await _accountService.RegisterAsync(request, Request.Headers["origin"]);
            return Ok(new { message = "Registration successful, please check your email for verification instructions" });
        }

        [HttpPost("verify-email")]
        public async Task<IActionResult> VerifyEmailAsync(VerifyEmailRequestDto request)
        {
            await _accountService.VerifyEmailAsync(request.Token);
            return Ok(new { message = "Verification successful, you can now login" });
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPasswordAsync(ForgotPasswordRequestDto request)
        {
            await _accountService.ForgotPasswordAsync(request, Request.Headers["origin"]);
            return Ok(new { message = "Please check your email for password reset instructions" });
        }

        [HttpPost("validate-reset-token")]
        public async Task<IActionResult> ValidateResetTokenAsync(ValidateResetTokenRequestDto request)
        {
            await _accountService.ValidateResetTokenAsync(request);
            return Ok(new { message = "Token is valid" });
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequestDto request)
        {
            await _accountService.ResetPasswordAsync(request);
            return Ok(new { message = "Password reset successful, you can now login" });
        }

        [Authorize(Role.Admin)]
        [HttpGet]
        public ActionResult<IEnumerable<AccountResponseDto>> GetAll()
        {
            return Ok(_accountService.GetAll());
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AccountResponseDto>> GetByIdAsync(int id)
        {
            // users can get their own account and admins can get any account
            if (id != Account.Id && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            var account = await _accountService.GetByIdAsync(id);
            return Ok(account);
        }

        [Authorize(Role.Admin)]
        [HttpPost]
        public async Task<ActionResult<AccountResponseDto>> CreateAsync(CreateAccountRequestDto model)
        {
            return Ok(await _accountService.CreateAsync(model));
        }

        [Authorize]
        [HttpPut("{id:int}")]
        public async Task<ActionResult<AccountResponseDto>> Update(int id, UpdateRequestDto model)
        {
            // users can update their own account and admins can update any account
            if (id != Account.Id && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            // only admins can update role
            if (Account.Role != Role.Admin)
                model.Role = null;

            return Ok(await _accountService.UpdateAsync(id, model));
        }

        [Authorize]
        [HttpDelete("{id:int}")]
        public IActionResult DeleteAsync(int id)
        {
            // users can delete their own account and admins can delete any account
            if (id != Account.Id && Account.Role != Role.Admin)
                return Unauthorized(new { message = "Unauthorized" });

            _accountService.DeleteAsync(id);
            return Ok(new { message = "Account deleted successfully" });
        }


        #region Private methods

        private void SetTokenCookie(string token)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };
            Response.Cookies.Append("refreshToken", token, cookieOptions);
        }

        private string GetIpv4Address()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }

        private string GetIpv6Address()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwarded-For"];
            }
            return HttpContext.Connection.RemoteIpAddress.MapToIPv6().ToString();
        }

        #endregion
    }
}
