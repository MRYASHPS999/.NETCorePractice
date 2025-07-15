using HRMSDotNetCoreMiniProject.Data;
using HRMSDotNetCoreMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMSDotNetCoreMiniProject.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDbContext db;
        public LoginController(ApplicationDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult SignUp()
        {
            return View();

        }

        [HttpPost]
        public IActionResult SignUp(UserDetails usr)
        {
            if (ModelState.IsValid)
            {
                usr.userrole = "User";
                db.userdetails.Add(usr);

                db.SaveChanges();
                TempData["success"] = "User Registered Successfully";
                return RedirectToAction("SignIn");
            }
            else
            {
                //TempData["failure"] = "User Registered Successfully";
                return View();

            }


        }


        public IActionResult SignIn()
        {
            return View();

        }

        //[HttpPost]
        //public IActionResult SignIn(string Email,string passowrd)
        //{

        //    var data = db.userdetails.Where(x => x.Email.Equals(Email)).SingleOrDefault();

        //    if (data != null)
        //    {

        //        bool admin = data.Equals(passowrd) && data.userrole.Equals("Admin");
        //        bool user = data.Equals(passowrd) && data.userrole.Equals("User");

        //        if (admin)
        //        {
        //            return RedirectToAction("AdminDashBoard");
        //        }
        //        if (user)
        //        {
        //            return RedirectToAction("UserDashBoard");

        //        }
        //    }
        //    else
        //    {
        //        TempData["errormail"] = "Invalid Email ID";
        //    }

        //    return View();

        //}

        public IActionResult AdminDashboard()
        {
            var role = HttpContext.Session.GetString("UserRole");

            if (HttpContext.Session.GetString("UserRole") != "Admin")
                return RedirectToAction("SignIn");

            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.WelcomeMsg = TempData["welcome"]?.ToString();

            return View();
        }

        public IActionResult UserDashboard()
        {
            var role = HttpContext.Session.GetString("UserRole");

            if (HttpContext.Session.GetString("UserRole") != "User")
                return RedirectToAction("SignIn");

            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.WelcomeMsg = TempData["welcome"]?.ToString();

            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string Email, string passowrd)
        {

            var emaildata = db.userdetails.Where(x => x.Email.Equals(Email)).SingleOrDefault();

            if (emaildata != null)
            {

                var passdata = db.userdetails.Where(x => x.password.Equals(passowrd)).SingleOrDefault();

                if (passdata != null)
                {

                    HttpContext.Session.SetString("Email", passdata.Email);
                    HttpContext.Session.SetString("UserRole", passdata.userrole);
                    HttpContext.Session.SetString("Username", passdata.username ?? "User");
                    TempData["welcome"] = $"Welcome, {passdata.username}!";

                    bool admin = passdata.userrole.Equals("Admin");
                    bool user = passdata.userrole.Equals("User");

                    

                   

                    if (admin)
                    {
                        return RedirectToAction("AdminDashBoard");
                    }
                    if (user)
                    {
                        return RedirectToAction("UserDashBoard");
                    }

                }
                else
                {
                    TempData["errormsg"] = "Invalid Passowrd";
                }




            }
            else
            {
                TempData["errormail"] = "Invalid Email ID";
            }
            return View();

        }



    }
}
