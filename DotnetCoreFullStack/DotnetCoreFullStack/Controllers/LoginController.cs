using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
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
