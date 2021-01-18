using ColonyManager.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ColonyManager.Utility.Helpers
{
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private IList<Role> _roles;

        public AuthorizeAttribute(params Role[] roles)
        {
            _roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var account = (Account)context.HttpContext.Items["Account"];
            if (account == null || (_roles.Any() && !_roles.Contains(account.Role)))
            {
                // not logged in or role not authorized
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
