using DotnetCoreFullStack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var p = new List<Product>() {

                new Product{pid = 101, pname = "a", pcat="Elect", price = 10000.00},
                new Product{pid = 102, pname = "b", pcat="Elect", price = 10000.00},
                new Product{pid = 103, pname = "c", pcat="Elect", price = 10000.00},
                new Product{pid = 104, pname = "d", pcat="Elect", price = 10000.00}

            };

            //var e = new List<Emp>()
            //{

            //    new Emp{id= 121, name="John1" ,salary=10000 },
            //    new Emp{id= 122, name="John1" ,salary=10000 },
            //    new Emp{id= 123, name="John1" ,salary=10000 },

            //};


            //var c = new Combine()
            //{
            //    emps = e,
            //    prd = p
            //};



            return View(p);
        }


        

        public IActionResult CombinedData()
        {
            var p = new List<Product>() {

                new Product{pid = 101, pname = "a", pcat="Elect", price = 10000.00},
                new Product{pid = 102, pname = "b", pcat="Elect", price = 10000.00},
                new Product{pid = 103, pname = "c", pcat="Elect", price = 10000.00},
                new Product{pid = 104, pname = "d", pcat="Elect", price = 10000.00}

            };

            var e = new List<Emp>()
            {

                new Emp{id= 121, name="John1" ,salary=10000 },
                new Emp{id= 122, name="John1" ,salary=10000 },
                new Emp{id= 123, name="John1" ,salary=10000 },

            };


            var c = new Combine()
            {
                emps = e,
                prd = p
            };



            return View(c);
        }
        


        public IActionResult Home()
        {

            var e = new List<Emp>()
            {

                new Emp{id= 121, name="John1" ,salary=10000 },
                new Emp{id= 122, name="John1" ,salary=10000 },
                new Emp{id= 123, name="John1" ,salary=10000 },

            };

            ViewData["msg"] = e;
            return View();
        }


        public IActionResult About()
        {

            var e = new List<Emp>()
            {

                new Emp{id= 121, name="John1" ,salary=10000 },
                new Emp{id= 122, name="John1" ,salary=10000 },
                new Emp{id= 123, name="John1" ,salary=10000 },

            };

            ViewBag.data = e;
            return View();
        }


    }
}
