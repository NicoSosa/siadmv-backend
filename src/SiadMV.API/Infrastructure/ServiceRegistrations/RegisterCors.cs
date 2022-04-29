using SiadMV.API.Constants;
using SiadMV.ServiceBase.SeedWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SiadMV.API.Infrastructure.ServiceRegistrations
{
    public class RegisterCors : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    CoreConstants.CorsPolicy,
                    builder => builder
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .SetIsOriginAllowed(_ => true));
            });
        }
    }
}
