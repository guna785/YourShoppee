using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.Auth;
using YourShoppee.BL.Models;
using YourShoppee.Models;
using YourShoppee.Models.Models;
using YourShoppee.TokenService;

namespace YourShoppee.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticateApi _auth;
        private readonly IGenerateJwtToken _token;
        private readonly IUserRefreshTokenRepository _tokenRefresh;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        public AccountController(IAuthenticateApi auth, IGenerateJwtToken token, IUserRefreshTokenRepository tokenRefresh,
            IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _auth = auth;
            _token = token;
            _tokenRefresh = tokenRefresh;
            _configuration = configuration;
            _userManager = userManager;
        }
        [HttpPost]
        [ActionName("Auth")]
        public async Task<IActionResult> Auth([FromBody] LoginModel usr)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    data = "Bad Request"
                });
            }
            var u = await _auth.Authenticate(usr);
            if (u != null)
            {
                return Ok(new
                {
                    data = u,
                    uid = u.uname
                });
            }
            return BadRequest(new
            {
                data = "Error In Request"
            });

        }
        [HttpPost]
        [ActionName("RenewUser")]
        public async Task<IActionResult> RenewUser([FromBody] JwtToken jwtToken)
        {
            if (jwtToken == null)
            {
                return BadRequest(new
                {
                    data = "Invalid request"
                });
            }
            var handler = new JwtSecurityTokenHandler();
            SecurityToken validatedToken;
            IPrincipal principal = handler.ValidateToken(jwtToken.jwt, GetTokenValidationparameter(), out validatedToken);
            var userName = principal.Identity.Name;
            var u = await _userManager.FindByNameAsync(userName);
            if (_tokenRefresh.CheckIfRefreshTokenIsValid(u.Id, jwtToken.refreshToken))
            {
                var role = principal.IsInRole("Admin") ? "Admin" : "User";
                var token = _token.GenerateJwt(userName, role);
                // Arbitrary method to get the token
                //var handler = new JwtSecurityTokenHandler();
                var tken = handler.ReadToken(token) as JwtSecurityToken;
                var tokenExpiryDate = tken.ValidTo;
                var newjwtToken = new JwtToken() { refreshToken = new RefreshTokenGenerator().GenerateRefreshToken(32), jwt = token };
                await _tokenRefresh.SaveOrUpdateUserRefreshToken(new RefreshTokenView()
                {
                    Created = DateTime.Now,
                    CreatedByIp = HttpContext.Connection.RemoteIpAddress.ToString(),
                    Expires = tokenExpiryDate,
                    Refreshtoken = newjwtToken.refreshToken,
                    Token = token,
                    uid = u.Id
                }, jwtToken.refreshToken);
                return Ok(newjwtToken);

            }
            return BadRequest(new
            {
                data = "Invalid request"
            });
        }
        private TokenValidationParameters GetTokenValidationparameter()
        {

            var key = Encoding.ASCII.GetBytes(_configuration["AppSettings:Secret"]);
            return new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

        }
    }
}
