using ProductsApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp2.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Drink", Category = "Schmoceries", Price = 42 },
            new Product { Id = 2, Name = "Yo-bo", Category = "Pets", Price = 55.75M },
            new Product { Id = 3, Name = "Hardware", Category = "Software", Price = 0.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        
        public ProductsController()
        {

        }

        public ProductsController(Product[] products)
        {
            this.products = products;
        }
    }
}
