using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.BL.Contract;
using YourShoppee.BL.Models;
using YourShoppee.Models.Enums;
using YourShoppee.Models.Models;

namespace YourShoppee.BL.Service
{
    public class Authenticate : IAuthenticate
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IIdentityUserService _service;
        private readonly ILogger<Authenticate> _logger;
        public Authenticate(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager,
            IIdentityUserService service, ILogger<Authenticate> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _service = service;
            _logger = logger;
        }
        public async Task<AuthenticatedModel> Auth(LoginModel model)
        {
            _logger.LogInformation($"Authentication Started {Newtonsoft.Json.JsonConvert.SerializeObject(model)}");
            var AM = new AuthenticatedModel();

            var res = await _signInManager.PasswordSignInAsync(model.uname, model.password, model.RememberMe, lockoutOnFailure: true);
            if (res.Succeeded)
            {
                _logger.LogInformation("Login Succeeded");
                var usr = await _userManager.FindByNameAsync(model.uname);
                AM.ID = usr.Id.ToString();
                AM.name = usr.Name;
                AM.uname = usr.UserName;
                AM.sign = res;
                AM.role = usr.userType == UserType.Admin ? "Admin" : "User";
                AM.permissions = usr.userType == UserType.Admin ? new List<string>() { "SuperUser" } : await _userManager.GetRolesAsync(usr);
            }
            _logger.LogInformation("Authentication Failed");
            AM.sign = res;
            return AM;
        }

        public async Task Initialize(HttpContext httpContext)
        {
            var usr = await _userManager.FindByNameAsync("admin");
            if (usr == null)
            {
                var appUser = new ApplicationUser()
                {
                    UserName = "admin",
                    Email = "info@b2lsolutions.in",
                    userType = UserType.Admin,
                    Name = "Admin"
                };
                var res = await _userManager.CreateAsync(appUser, "Ashok@1991");
                if (res.Succeeded)
                {
                    await _service.ConfirmEmailGenerate(appUser, httpContext);
                }
                else
                {

                }
            }
        }

        public Task<AuthenticatedModel> RefreshToken(string refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}
