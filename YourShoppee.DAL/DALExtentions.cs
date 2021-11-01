using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.DAL.Context;
using YourShoppee.DAL.Contract;
using YourShoppee.DAL.Repo;
using YourShoppee.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace YourShoppee.DAL
{
    public static class DALExtentions
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services, IConfiguration configuration)
        {
            var conStr = configuration.GetSection("DataBaseConnections:connStr").Value;
            var lockoutOptions = new LockoutOptions()
            {
                AllowedForNewUsers = true,
                DefaultLockoutTimeSpan = TimeSpan.FromHours(10),
                MaxFailedAccessAttempts = 3
            };
            services.AddDefaultIdentity<ApplicationUser>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireLowercase = true;
                opt.Password.RequireNonAlphanumeric = true;
                opt.Password.RequireUppercase = true;
                opt.Lockout = lockoutOptions;
                opt.SignIn.RequireConfirmedAccount = true;
                opt.SignIn.RequireConfirmedEmail = true;
                opt.User.RequireUniqueEmail = true;
            }).AddRoles<ApplicationRole>()
                  .AddEntityFrameworkStores<IdentityContext>()
                  .AddDefaultTokenProviders();
            services.AddDbContext<IdentityContext>(options => options.UseMySQL(conStr));
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(conStr));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }
    }
}
