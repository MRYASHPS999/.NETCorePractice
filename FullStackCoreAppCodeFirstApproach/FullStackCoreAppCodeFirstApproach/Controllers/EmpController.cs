using FullStackCodeFirstApproach.Data;
using Microsoft.AspNetCore.Mvc;

namespace FullStackCoreAppCodeFirstApproach.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationDbContext db;
        public EmpController(ApplicationDbContext db) 
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmp() 
        {
            return View();
        }

    }



}
