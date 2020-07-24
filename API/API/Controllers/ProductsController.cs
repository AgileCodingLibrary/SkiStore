using Core.Contracts;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }
       
        
        /// <summary>
        ///  Get All Products from the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IReadOnlyList<Product>> Get()
        {
            return await _repo.GetProductsAsync();
        }


        /// <summary>
        /// Get single product from the database for the given id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}")]
        public string Get(int Id)
        {
            return $"single product with id {Id}";
        }
    }
}