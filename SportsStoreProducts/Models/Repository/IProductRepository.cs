using SportsStoreProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreProducts.Models.Repository
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetAllProducts();
	}
}
