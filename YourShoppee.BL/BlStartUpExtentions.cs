using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.BL.Contract;
using YourShoppee.BL.Service;

namespace YourShoppee.BL
{
    public static class BlStartUpExtentions
    {
        public static IServiceCollection AddBLService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IAuthenticate), typeof(Authenticate));
            services.AddScoped(typeof(IIdentityUserService), typeof(IdentityUserService));
            return services;
        }
    }
}
