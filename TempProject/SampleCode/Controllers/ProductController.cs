using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCode.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route(("list"))]
        public IEnumerable<ProductModel> Get()
        {
            return GetProducts();
        }

        public List<ProductModel> GetProducts()
        {
            var product1 = new ProductModel { Id = 1, Name = "Medical", Jurisdiction = "CA" };
            var produc21 = new ProductModel { Id = 2, Name = "Dental", Jurisdiction = "CA" };
            var product3 = new ProductModel { Id = 3, Name = "Vision", Jurisdiction = "CA" };

            return new List<ProductModel>() {product1, produc21, product3 };
        }


    }
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Jurisdiction { get; set; }
    }
}
