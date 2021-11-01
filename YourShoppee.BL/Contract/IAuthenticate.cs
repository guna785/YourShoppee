using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.BL.Models;

namespace YourShoppee.BL.Contract
{
    public interface IAuthenticate
    {
        Task<AuthenticatedModel> Auth(LoginModel model);
        Task<AuthenticatedModel> RefreshToken(string refreshToken);
        Task Initialize(HttpContext httpContext);
    }
}
