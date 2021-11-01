using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.BL.Contract;
using YourShoppee.BL.Helper;
using YourShoppee.BL.Models;
using YourShoppee.Models.Models;

namespace YourShoppee.BL.Service
{
    public class IdentityUserService : IIdentityUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<IdentityUserService> _logger;
        private readonly IUrlHelper _helper;
        public IdentityUserService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<IdentityUserService> logger, IUrlHelper helper)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _helper = helper;
        }
        public async Task<bool> ResetPasswordUrl(string email, HttpContext httpContext)
        {
            var usr = await _userManager.FindByEmailAsync(email);
            if (usr == null)
                return false;
            var token = await _userManager.GeneratePasswordResetTokenAsync(usr);
            var confirmationLink = "";
            try
            {
                confirmationLink = _helper.Action("ResetPassword", "Login", new { token }, httpContext.Request.Scheme);
                string body = $"<div>Hello {httpContext.User.Identity.Name} , <a style='padding:20px;baground-color:blue;color:white;' href='{confirmationLink}'>Click Here To Reset Password</a>.</div>";
                EmailHelper emailHelper = new EmailHelper();
                bool emailResponse = await emailHelper.SendEmail(usr.Email, body);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;

        }
        public async Task<bool> ResetPassword(ResetPasswordViewModel model)
        {
            var user = await _userManager.
                 FindByNameAsync(model.UserName);

            var result = await _userManager.ResetPasswordAsync
                      (user, model.Token, model.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> ConfirmEmailGenerate(ApplicationUser appUser, HttpContext httpContext)
        {
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            var confirmationLink = "";
            try
            {
                confirmationLink = _helper.Action("ConfirmEmail", "Login", new { token, email = appUser.Email }, httpContext.Request.Scheme);
                string body = $"<div>Hello {httpContext.User.Identity.Name} , for Account Activation  <a style='padding:20px;baground-color:blue;color:white;' href='{confirmationLink}'>Click Here To Confirm Mail</a>.</div>";
                EmailHelper emailHelper = new EmailHelper();
                bool emailResponse = await emailHelper.SendEmail(appUser.Email, body);
                return emailResponse;
            }
            catch (Exception ex)
            {
                return false;
            }
             
        }

        public async Task<bool> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
                return false;

            var result = await _userManager.ConfirmEmailAsync(user, token);
            return result.Succeeded ? true : false;
        }
    }
}
