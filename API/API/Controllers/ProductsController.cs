using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "All products.";
        }

        [HttpGet("{Id}")]
        public string Get(int Id)
        {
            return $"single product with id {Id}";
        }
    }
}