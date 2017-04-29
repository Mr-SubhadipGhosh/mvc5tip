using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeAdmin.Models;
using System.Web.Security;

namespace EmployeeAdmin.Controllers
{
    public class AuthiController : Controller
    {
        //
        // GET: /Authi/
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoLogin(appusr u)
        {
            if (u.usrName == "admin" && u.pass == "ADMIN")
            {
                FormsAuthentication.SetAuthCookie(u.usrName, false);
                return RedirectToAction("Index", "home");
            }
            else
            {
                return View("login");
            }
        }
        [HttpPost]
        public ActionResult DoLogout(appusr u)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "home");

        }
	}
}