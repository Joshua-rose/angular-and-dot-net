using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedAPI.Web.API.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void AddScope(IServiceProvider services)
        {
            services.AddScoped<IApplicationContext, ApplicationContext>();
            services.AddScoped<IUserMap, UserMap>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
