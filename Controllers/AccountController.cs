using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace unity_course_1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string Username, string Password)
        {
            if(Username == "admin" && Password == "manager")
            {
                return RedirectToAction("Dashboard", "Admin"); // action, controller
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }

            //return View();
        }

        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}