using SiadMV.Manager.Infrastructure.Services;
using SiadMV.Manager.Infrastructure.Services.Identity;
using SiadMV.Manager.Services;
using SiadMV.Manager.Services.Identity;
using SiadMV.ServiceBase.SeedWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SiadMV.Manager.Infrastructure.ServiceRegistrations
{
    public class RegisterManagerService : IServiceRegistration
    {
        public void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserIdentityService, UserIdentityService>();
            services.AddScoped<IUserAddressService, UserAddressService>();
            services.AddScoped<IUserProviderService, UserProviderService>();
            services.AddScoped<ICartService, CartService>();
        }
    }
}
