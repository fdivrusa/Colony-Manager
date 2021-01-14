﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Domain.Models.Account
{
    public class CreateAccountRequestDto
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}