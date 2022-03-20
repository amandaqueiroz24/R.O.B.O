using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Becomex.ROBO.Infra.Repository.Microsoft.Extensions.DependencyInjection
{
	public static class InfraRepositoryServiceColletion
	{
		public static IServiceCollection AddInfraRepository(this IServiceCollection services)
		{
			if (services == null)
				throw new ArgumentException(nameof(services));

			//services.AddScoped<BrandReadOnlyRepository, BrandRepository>();


			return services;
		}
	}
}
