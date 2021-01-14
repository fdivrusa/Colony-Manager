using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Domain.Models.Account
{
    public class ResetPasswordRequestDto
    {

        public string Token { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
