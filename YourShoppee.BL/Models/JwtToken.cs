using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourShoppee.BL.Models
{
    public class JwtToken
    {
        public string jwt { get; set; }
        public string refreshToken { get; set; }
    }
}
