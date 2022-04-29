using SiadMV.DataAccess.Infrastructure.Extensions;
using EmpanadUS.ServiceBase.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SiadMV.Manager.Infrastructure.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static void AddManagerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseServices(configuration);
            services.AddServicesInAssembly<MappingProfile>(configuration);
        }
    }
}
