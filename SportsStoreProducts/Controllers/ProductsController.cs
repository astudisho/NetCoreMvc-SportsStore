using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SportsStoreProducts.Models;
using SportsStoreProducts.Models.Repository;

namespace SportsStoreProducts.Controllers
{
	public class ProductsController : Controller
	{
		private IProductRepository _productsRepository;

		public ProductsController(IProductRepository productRepository)
		{
			_productsRepository = productRepository;
		}

		public ActionResult List() =>	Ok(_productsRepository.GetAllProducts());		
	}
}
