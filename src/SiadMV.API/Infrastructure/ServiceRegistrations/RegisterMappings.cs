using AutoMapper;
using SiadMV.Manager.Infrastructure.Helpers;
using SiadMV.ServiceBase.Registering.Service;

namespace SiadMV.API.Infrastructure.ServiceRegistrations
{
	public class RegisterMappings : RegisterMappingsBase
	{
		protected override IMapper CreateMapper()
		{
			return new MapperConfiguration(config =>
			{
				config.AddMaps(typeof(MappingProfile).Assembly);
				config.AddMaps(ManagerMappingsHelper.GetMappingsAssemblies());
			})
			.CreateMapper();
		}
	}
}
