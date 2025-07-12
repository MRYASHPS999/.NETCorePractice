using Microsoft.AspNetCore.Mvc;

namespace HRMSDotNetCoreMiniProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginPage() 
        {
            
            return View();
        
        }

    }
}
