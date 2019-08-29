using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStoreProducts.Data.Context;
using SportsStoreProducts.Models.Domain;

namespace SportsStoreProducts.Models.Repository.Implementation
{
	public class EFProductRepository : IProductRepository
	{
		private SportsStoreDbContext _dbContext;
		public EFProductRepository(SportsStoreDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IEnumerable<Product> GetAllProducts()
		{
			throw new NotImplementedException();
		}
	}
}
