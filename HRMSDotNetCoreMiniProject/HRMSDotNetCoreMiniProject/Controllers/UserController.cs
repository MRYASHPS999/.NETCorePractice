using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRMSDotNetCoreMiniProject.Controllers
{
    public class UserController : Controller
    {

        IUserService service;
        ApplicationDbContext db;
        public UserController(IUserService service, ApplicationDbContext db)
        {
            this.service = service;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyDocuments()
        {

            int userId = int.Parse(HttpContext.Session.GetString("UserId").ToString());
            var docs = servi

            return View();
        }





    }
}
