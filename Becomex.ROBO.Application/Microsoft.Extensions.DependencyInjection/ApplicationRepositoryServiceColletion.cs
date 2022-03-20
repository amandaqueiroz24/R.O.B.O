
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Becomex.ROBO.Application.Microsoft.Extensions.DependencyInjection
{
	public static class ApplicationRepositoryServiceColletion
	{
		public static IServiceCollection AddApplicationRepository(this IServiceCollection services,
																 ApplicationConfiguration applicationConfiguration)
		{
			if (services == null)
				throw new ArgumentException(nameof(services));

			services.AddSingleton(applicationConfiguration);
			//services.AddScoped<IBrandService, BrandService>();

			return services;
		}
	}
}
