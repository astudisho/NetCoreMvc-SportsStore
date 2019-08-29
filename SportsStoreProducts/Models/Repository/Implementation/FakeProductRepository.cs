using SportsStoreProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreProducts.Models.Repository.Implementation
{
	public class FakeProductRepository : IProductRepository
	{
		public IEnumerable<Product> GetAllProducts() =>
			new List<Product>
			{
				new Product { Id = 1, Name = "Tennis", Price = 2499 },
				new Product { Id = 2, Name = "Football", Price = 249 },
				new Product { Id = 3, Name = "Tennis ball", Price = 49 },
				new Product { Id = 4, Name = "Pants", Price = 649 },
				new Product { Id = 5, Name = "Jacket", Price = 899 },
			};
		
	}
}
