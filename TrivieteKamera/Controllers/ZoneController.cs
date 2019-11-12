using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrivieteKamera.Controllers
{
    public class ZoneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ZoneEdit()
        {
            return View();
        }
        public IActionResult ZoneAdd()
        {
            return View();
        }
        public IActionResult ZoneList()
        {
            if (UserController.LoggedIn)
            {
                ViewBag.Logged = true;
            }
            string[] links = { "ZoneAdd", "ZoneEdit"
            };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
            return View();
        }
        public static Dictionary<string, KeyValuePair<string, string>> MeniuItemDictionary = new Dictionary<string, KeyValuePair<string, string>>
        {
            {"ZoneEdit", new KeyValuePair<string,string>("Zone","Kalėjimo zonos redagavimas" )},
            {"ZoneAdd", new KeyValuePair<string,string>("Zone","Kalėjimo zonos kūrimas" )},
            {"ZoneList", new KeyValuePair<string,string>("Zone","Kalėjimo zonos" )}

        };
    }
}