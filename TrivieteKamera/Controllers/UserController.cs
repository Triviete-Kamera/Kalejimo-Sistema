using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrivieteKamera.Controllers
{
    public class UserController : Controller
    {
        public static bool LoggedIn = false;
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Logged()
        {
            LoggedIn = true;

            return RedirectToAction("Index", "Navigation");
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}