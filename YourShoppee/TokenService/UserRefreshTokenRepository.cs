using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourShoppee.DAL.Contract;
using YourShoppee.Models;
using YourShoppee.Models.Models;

namespace YourShoppee.TokenService
{
    public interface IUserRefreshTokenRepository
    {
        Task SaveOrUpdateUserRefreshToken(RefreshTokenView refreshToken, string oldRefreshToken = "");
        bool CheckIfRefreshTokenIsValid(int Uid, string refreshToken);
    }
    public class UserRefreshTokenRepository : IUserRefreshTokenRepository
    {
        private IGenericRepository<RefreshToken> _refreshtoken;
        public UserRefreshTokenRepository(IGenericRepository<RefreshToken> refreshtoken)
        {
            _refreshtoken = refreshtoken;
        }
        public bool CheckIfRefreshTokenIsValid(int Uid, string refreshToken)
        {
            string refToken = _refreshtoken.GetAll().AsEnumerable().Where(x => x.Id == Uid && x.IsActive).FirstOrDefault().Refreshtoken;

            return refToken.Equals(refreshToken);
        }

        public async Task SaveOrUpdateUserRefreshToken(RefreshTokenView refreshToken, string oldRefreshToken = "")
        {
            if (oldRefreshToken != "" && _refreshtoken.GetAll().AsEnumerable().Any(x => x.Refreshtoken == oldRefreshToken && x.IsActive))
            {
                var RFT = _refreshtoken.GetAll().AsEnumerable().Where(x => x.Refreshtoken == oldRefreshToken && x.IsActive).FirstOrDefault();
                RFT.createdAt = DateTime.Now;
                RFT.CreatedByIp = refreshToken.CreatedByIp;
                RFT.Expires = refreshToken.Expires;
                RFT.Refreshtoken = refreshToken.Refreshtoken;
                RFT.Revoked = refreshToken.Revoked;
                RFT.RevokedByIp = refreshToken.RevokedByIp;
                RFT.Token = refreshToken.Token;
                RFT.uid = refreshToken.uid;
                await _refreshtoken.Update(RFT);
                //RefreshToken[refreshToken.UserName] = refreshToken.RefreshToken;
            }
            else
            {

                await _refreshtoken.Add(new RefreshToken()
                {
                    createdAt = DateTime.Now,
                    CreatedByIp = refreshToken.CreatedByIp,
                    Expires = refreshToken.Expires,
                    Refreshtoken = refreshToken.Refreshtoken,
                    Revoked = refreshToken.Revoked,
                    RevokedByIp = refreshToken.RevokedByIp,
                    Token = refreshToken.Token,
                    uid = refreshToken.uid
                });
            }
        }


    }
}
