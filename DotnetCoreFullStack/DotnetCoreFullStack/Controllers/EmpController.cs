using DotnetCoreFullStack.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreFullStack.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            var e = new Emp()
            {
                id = 1,
                name = "Test",
                salary = 10000
            };

            return View(e);
        }
    }
}
