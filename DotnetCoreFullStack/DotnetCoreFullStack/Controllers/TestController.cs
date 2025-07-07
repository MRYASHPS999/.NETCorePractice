using DotnetCoreFullStack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //TempData["msg"] = "This message is from Tempdata";

            TempData["mydata"] = "This IS Tempdata Value";

            TempData.Keep("mydata");

            //string email = "xyz";

            //if (email.Equals("xyz"))
            //{
            //    TempData["msg"] = "Email Checked Sucessfully";
            //    return RedirectToAction("About");
            //}


            return View();
        }

        public IActionResult About() 
        {

            var det = new List<Emp>()
            {   
                new Emp{id=101, name="anbc", salary=123456 },
                new Emp{id=102, name="test", salary=123456 },
                new Emp{id=103, name="test2", salary=123456 },
            };

            TempData["empData"] = det;

            return View();
        }

        public IActionResult Contact() 
        {
            //if (TempData["msg"] != null) 
            //{ 

            //}

            TempData.Keep("mydata");

            return View();
        }

        public IActionResult Test()
        {
            return View();
        }


    }
}
