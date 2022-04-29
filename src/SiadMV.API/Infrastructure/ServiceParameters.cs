using SiadMV.API.Constants;
using SiadMV.ServiceBase.SeedWork;
using System;

namespace SiadMV.API.Infrastructure
{
	public class ServiceParameters : IServiceParameters
	{
		public ServiceParameters()
		{
			ApiStartup = typeof(Startup);
			ClientAlias = CoreConstants.ClientAlias;
			ContextPath = CoreConstants.ContextPath;
			SwaggerDocumentName = typeof(Startup).Assembly.GetName().Name;
		}

		public Type ApiStartup { get; }

		public string ClientAlias { get; }

		public string ContextPath { get; }

		public string SwaggerDocumentName { get; }
	}
}
