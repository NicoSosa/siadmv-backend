using SiadMV.API.Constants;
using EmpanadUS.ServiceBase.SeedWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace SiadMV.API.Infrastructure.AppRegistrations
{
    public class ConfigureCors : IAppBuilderConfiguration
    {
        public void ConfigureApp(IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseCors(CoreConstants.CorsPolicy);
        }
    }
}
