using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace YourShoppee.TokenService
{
    public class RefreshTokenGenerator
    {
        public string GenerateRefreshToken()
        {
            return Guid.NewGuid().ToString();
        }
        public string GenerateRefreshToken(int size = 32)
        {
            var refToken = new byte[size];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(refToken);
                return Convert.ToBase64String(refToken);
            }

        }
    }
}
