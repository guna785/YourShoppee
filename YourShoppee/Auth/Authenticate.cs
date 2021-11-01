using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourShoppee.BL.Contract;
using YourShoppee.BL.Models;
using YourShoppee.TokenService;

namespace YourShoppee.Auth
{
    public interface IAuthenticateApi
    {
        Task<AuthenticatedModel> Authenticate(LoginModel model);
        Task<string> ChangePassword(ResetPasswordViewModel change);
        Task<string> resetPassword(string email);
    }
    public class AuthenticateApi: IAuthenticateApi
    {
        private readonly IAuthenticate _authenticate;
        private readonly IGenerateJwtToken _generateJwtToken;
        public AuthenticateApi(IAuthenticate authenticate, IGenerateJwtToken generateJwtToken)
        {
            _authenticate = authenticate;
            _generateJwtToken = generateJwtToken;
        }

        public async Task<AuthenticatedModel> Authenticate(LoginModel model)
        {
            var usr = await _authenticate.Auth(model);
            if (usr == null)
                return null;


            var token = _generateJwtToken.GenerateJwt(usr.uname, usr.role);
            var jwtToken = new JwtToken() { refreshToken = new RefreshTokenGenerator().GenerateRefreshToken(32), jwt = token };
            usr.Token = jwtToken;
            return usr;
        }

        public async Task<string> ChangePassword(ResetPasswordViewModel change)
        {
            throw new NotImplementedException();
        }           

        public async Task<string> resetPassword(string email)
        {
            throw new NotImplementedException();
        }
    }
}
