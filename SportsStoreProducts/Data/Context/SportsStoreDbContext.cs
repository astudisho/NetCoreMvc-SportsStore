using Microsoft.EntityFrameworkCore;
using SportsStoreProducts.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreProducts.Data.Context
{
	public class SportsStoreDbContext : DbContext
	{
		public SportsStoreDbContext(DbContextOptions<SportsStoreDbContext> options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
	}
}
