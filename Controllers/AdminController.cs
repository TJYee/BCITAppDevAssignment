using BCITAppDevAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BCITAppDevAssignment.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Validate the admin credentials (in real app use hashed password)
                if (model.Username == "admin" && model.Password == "adminpass")
                {
                    // Set authentication and redirect to Admin Dashboard
                    Session["AdminUser"] = model.Username;
                    return RedirectToAction("Index", "Event");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }

            // If we got this far, something failed; redisplay form
            return View(model);
        }
    }
}