using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Domain.Models.Account
{
    public class VerifyEmailRequestDto
    {
        public string Token { get; set; }
    }
}
