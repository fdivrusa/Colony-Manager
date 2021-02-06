using ColonyManager.Core;
using ColonyManager.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Utility.Middlewares
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        public async Task Invoke(HttpContext context, ColonyManagerDbContext colonyManagerDbContext)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                await AttachAccountToContext(context, colonyManagerDbContext, token);

            await _next(context);
        }

        private async Task AttachAccountToContext(HttpContext context, ColonyManagerDbContext colonyManagerDbContext, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var accountId = int.Parse(jwtToken.Claims.First(x => x.Type == "Id").Value);

                // attach account to context on successful jwt validation
                context.Items["Account"] = await colonyManagerDbContext.Accounts.Where(x => x.Id == accountId).SingleOrDefaultAsync();
            }
            catch
            {
                // do nothing if jwt validation fails
                // account is not attached to context so request won't have access to secure routes
            }
        }
    }
}
