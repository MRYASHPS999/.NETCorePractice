using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Models;
using HRMSDotNetCoreMiniProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.Design;

namespace HRMSDotNetCoreMiniProject.Controllers
{
    public class AdminController : Controller
    {


        ApplicationDbContext db;
        IAdminService service;
        public AdminController(ApplicationDbContext db,IAdminService service)
        {
            this.db = db;
            this.service = service;
        }

       

        public IActionResult Index()
        {
            var data = db.employees.Include(a => a.manager).Include(a => a.department).ToList();
            
            return View(data);
           
        }

        //files section starts 
        public IActionResult UploadFile()
        {
            ViewBag.employees = new SelectList(db.employees.ToList(), "empid", "empname");
            return View(new DocumentUpload());
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file, int empid)
        {
            string uploadedBy = "Admin"; // Get from session if needed
            service.UploadDocument(file, empid, uploadedBy);
            return RedirectToAction("DocumentList");
        }

        public IActionResult DocumentList()
        {
            var list = service.GetAllDocuments();
            return View(list);
        }
        //files section ends


        //Add Employee with fetching managers and departments
        public IActionResult AddEmp()
        {
            ViewBag.departments = new SelectList(db.departments.Where(a =>a.deptstatus.Equals("Active")).ToList(), "deptid", "deptname") ;
            ViewBag.managers = new SelectList(db.managers.Where(a => a.mgrstatus.Equals("Active")).ToList(), "mgrid", "mgrname");
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Employee emp)
        {


            service.AddEmp(emp);
            db.SaveChanges();
            return RedirectToAction("Index");

            //if (ModelState.IsValid)
            //{
            //    service.AddEmp(emp);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //else
            //{
                
            //    ViewBag.departments = new SelectList(db.departments.ToList(), "deptid", "deptname");
            //    ViewBag.managers = new SelectList(db.managers.ToList(), "mgrid", "mgrname");

            //    return View(emp);
            //}
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
