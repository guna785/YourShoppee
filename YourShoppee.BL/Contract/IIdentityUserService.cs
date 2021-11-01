using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.BL.Models;
using YourShoppee.Models.Models;

namespace YourShoppee.BL.Contract
{
    public interface IIdentityUserService
    {
        Task<bool> ResetPasswordUrl(string email, HttpContext httpContext);
        Task<bool> ResetPassword(ResetPasswordViewModel model);
        Task<bool> ConfirmEmailGenerate(ApplicationUser appUser, HttpContext httpContext);
        Task<bool> ConfirmEmail(string token, string email);
    }
}
