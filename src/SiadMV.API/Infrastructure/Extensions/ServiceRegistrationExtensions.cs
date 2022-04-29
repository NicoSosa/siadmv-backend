using SiadMV.Manager.Infrastructure.Extensions;
using SiadMV.ServiceBase.Infrastructure.Extensions;
using SiadMV.ServiceBase.SeedWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SiadMV.API.Infrastructure.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IServiceParameters, ServiceParameters>();
            services.AddBaseServices(configuration);
            services.AddManagerServices(configuration);
            services.AddServicesInAssembly<Startup>(configuration);
        }
    }
}
