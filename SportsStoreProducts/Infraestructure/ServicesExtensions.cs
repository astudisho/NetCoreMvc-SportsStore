using Microsoft.Extensions.DependencyInjection;
using SportsStoreProducts.Models.Repository;
using SportsStoreProducts.Models.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreProducts.Infraestructure
{
	internal static class ServicesExtensions
	{
		internal static void RegisterServices(this IServiceCollection services)
		{
			services.AddTransient<IProductRepository, FakeProductRepository>();
			services.AddTransient<IProductRepository, EFProductRepository>();
		}
	}
}
