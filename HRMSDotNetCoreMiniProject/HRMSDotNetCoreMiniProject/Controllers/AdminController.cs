using HRMSDotNetCoreMiniProject.Models;
using HRMSDotNetCoreMiniProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;

namespace HRMSDotNetCoreMiniProject.Controllers
{
    public class AdminController : Controller
    {


        IAdminService service;
        public AdminController(IAdminService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Add Employee
        public IActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Employee emp) 
        {
            
            service.AddEmp(emp);
            return RedirectToAction("Index");
        }

        //Add Department
        public IActionResult AddDept()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddDept(Department dept)
        {

            service.AddDept(dept);
            return RedirectToAction("Index");
        }

        //Add Manager
        public IActionResult AddMgr()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMgr(Manager mgr)
        {

            service.AddMgr(mgr);
            return RedirectToAction("Index");
        }

        public IActionResult DelEmp(int id)
        {
            service.DeleteEmp(id);
            return RedirectToAction("Index");
        }

        public IActionResult EditEmp(int id)
        {
            var data = service.findEmpById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult EditEmp(Employee emp)
        {
            service.UpdateEmpDetails(emp);
            return RedirectToAction("Index");
        }


    }
}
