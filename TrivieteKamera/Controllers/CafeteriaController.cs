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
            if (UserController.LoggedIn)
            {
                ViewBag.Logged = true;
            }
            string[] links = { "SupplierAdd", "SupplierRemove"
            };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
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
            if (UserController.LoggedIn)
            {
                ViewBag.Logged = true;
            }
            string[] links = { "CafeteriaRate"
            };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
            return View();
        }

        public IActionResult SupplyAdd()
        {
            return View();
        }
        public static Dictionary<string, KeyValuePair<string, string>> MeniuItemDictionary = new Dictionary<string, KeyValuePair<string, string>>
        {
            {"SupplierList", new KeyValuePair<string,string>("Cafeteria","Tiekėjų Sąrašas") },
            {"CafeteriaRate", new KeyValuePair<string,string>("Cafeteria","Pridėti valgyklos Ivertinimą" )},
            {"SupplyStats", new KeyValuePair<string,string>("Cafeteria","Išteklių statistika" )},
            {"SupplyList", new KeyValuePair<string,string>("Cafeteria","Maisto atsargų sąrašas" )},
            {"SupplierRemove", new KeyValuePair<string,string>("Cafeteria","Tiekėjo šalinimas" )},
            {"SupplierAdd", new KeyValuePair<string,string>("Cafeteria","Tiekėjo pridėjimas" )},
            {"CafeteriaRateList", new KeyValuePair<string,string>("Cafeteria","Valgyklų įvertinimų sąrašas" )},
            {"SupplyAdd", new KeyValuePair<string,string>("Cafeteria","Maisto atsargų papildymas" )},
        };
    }
}