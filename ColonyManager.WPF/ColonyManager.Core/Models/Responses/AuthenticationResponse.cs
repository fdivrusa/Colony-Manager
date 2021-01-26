﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Provider.Responses
{
    public class AuthenticationResponse : ResponseBase
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsVerified { get; set; }
        public string JwtToken { get; set; }
    }
}
