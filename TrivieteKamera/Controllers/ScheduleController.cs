using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrivieteKamera.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ScheduleCreate()
        {
            return View();
        }
        public IActionResult Schedule()
        {
            return View();
        }

    }
}