﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourShoppee.BL.Models
{
    public class LoginModel
    {
        [Required]
        public string uname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
