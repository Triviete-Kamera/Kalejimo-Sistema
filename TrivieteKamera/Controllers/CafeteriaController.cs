using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrivieteKamera.Controllers
{
    public class CafeteriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SupplierList()
        {
            return View();
        }

        public IActionResult CafeteriaRate()
        {
            return View();
        }

        public IActionResult SupplyStats()
        {
            return View();
        }

        public IActionResult SupplyList()
        {
            return View();
        }

        public IActionResult SupplierRemove()
        {
            return View();
        }

        public IActionResult SupplierAdd()
        {
            return View();
        }

        public IActionResult CafeteriaRateList()
        {
            return View();
        }

        public IActionResult SupplyAdd()
        {
            return View();
        }
    }
}