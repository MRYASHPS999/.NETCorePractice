using DotnetCoreFullStack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class TestLoginController : Controller
    {
        public IActionResult Index()
        {
            return View(); //render empty view 



        }

        [HttpPost]
        public IActionResult Index(string user, string pass)
        {

            if (user.Equals("Admin") && pass.Equals("Admin123"))
            {
                //return RedirectToAction("Index", "Product"); //to action of different controller. controller name is requiredm

                return RedirectToAction("Details"); //for action of same controller only no need fo mentioning controller name

            }
            else
            {
                TempData["msg"] = "Invalid Credentials!!";
            }

            return View();
        }





        public IActionResult Details() {

            return View();
        }

        [HttpPost]
        public IActionResult Impl(string user, string pass)
        {
            if (user.Equals("Admin") && pass.Equals("Admin123"))
            {
                //return RedirectToAction("Index", "Product"); //to action of different controller. controller name is requiredm

                return RedirectToAction("Details"); //for action of same controller only no need fo mentioning controller name

            }
            else
            {
                TempData["msg"] = "Invalid Credentials!!";
                return RedirectToAction("Index");
            }

            //return View();
        }

        public IActionResult UsingModel() 
        { 
        
            
            return View();


        }

        [HttpPost]
        public IActionResult UsingModel(Emp e)
        {
            
            return View(e);
        
        }


        public IActionResult MyData() 
        {
        
            return View();

        }



        [HttpPost]
        public IActionResult MyData(Employee emp)
        {
            if (ModelState.IsValid)
            {

                return View(emp);

            }
            else 
            {
                return View();
            }

            

        }


        public IActionResult Login(string user, string pass)
        {


            var p = new List<Product>() {

                new Product{pid = 101, pname = "a", pcat="Elect", price = 10000.00},
                new Product{pid = 102, pname = "b", pcat="Elect", price = 10000.00},
                new Product{pid = 103, pname = "c", pcat="Elect", price = 10000.00},
                new Product{pid = 104, pname = "d", pcat="Elect", price = 10000.00}

            };

            if (user.Equals("Admin") && pass.Equals("Admin123"))
            {
                TempData["name"] = user;

                return RedirectToAction("Index");
            }
            else
            {

                TempData["error"] = "Invalid Credentials";

            }

            return View();

        }


    }
}
