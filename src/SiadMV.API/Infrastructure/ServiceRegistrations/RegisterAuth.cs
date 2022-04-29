using SiadMV.API.Constants;
using EmpanadUS.ServiceBase.SeedWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace SiadMV.API.Infrastructure.ServiceRegistrations
{
    public class RegisterAuth: IServiceRegistration
    {
       public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.Authority = configuration[IdentityPlatformConstants.Authority];
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = true,
                       ValidIssuer = configuration[IdentityPlatformConstants.ValidIssuer],
                       ValidateAudience = true,
                       ValidAudience = configuration[IdentityPlatformConstants.ValidAudience],
                       ValidateLifetime = true
                   };
               });
        }
	}
}
