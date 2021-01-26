using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedAPI.Web.API.App_Start
{
    public class JwtTokenConfig
    {
        public static void AddAuthentication(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudance = true,
                    ValidateLifetime = true,
                    ValidateIssuesSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidIAudience = configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))

                }
                services.AddCors();
            })
        }
    }
}
