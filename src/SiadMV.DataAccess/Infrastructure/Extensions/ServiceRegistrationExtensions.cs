using EmpanadUS.ServiceBase.DAL.Infrastructure.Extensions;
using EmpanadUS.ServiceBase.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SiadMV.DataAccess.Infrastructure.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static void AddDatabaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALServices(configuration);
            services.AddServicesInAssembly<MappingProfile>(configuration);
        }
    }
}
