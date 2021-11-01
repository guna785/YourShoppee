using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourShoppee.BL.Models
{
    public class AuthenticatedModel
    {
        public string ID { get; set; }
        public string uname { get; set; }
        public string name { get; set; }
        public SignInResult sign { get; set; }
        public JwtToken Token { get; set; }
        public string role { get; set; }
        public IList<string> permissions { get; set; }
    }
}
