using DotnetCoreFullStack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var pname = new List<Product>() {

                new Product{pid = 101, pname = "a", pcat="Elect", price = 10000.00},
                new Product{pid = 102, pname = "b", pcat="Elect", price = 10000.00},
                new Product{pid = 103, pname = "c", pcat="Elect", price = 10000.00},
                new Product{pid = 104, pname = "d", pcat="Elect", price = 10000.00}

            };

            
            return View(pname);
        }
    }
}
