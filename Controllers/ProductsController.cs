using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Module1AssignmentAngular.Models;
using Module1AssignmentAngular.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Module1AssignmentAngular.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context) { this._context = context; }
        
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            List<Product> products;


            {
                products = _context.Products.ToList();
               
            }
            return products;
        }

        
    }
}

