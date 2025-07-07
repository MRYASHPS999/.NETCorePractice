using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            TempData["msg"] = "This message from tempdata";
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public string disName(string name)
        {
            return $"Your Name is {name}";
        }

        public int findAdd(int x,int y) {

            return (x + y);

        }




    }
}
