using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrivieteKamera.Controllers
{
    public class PrisonerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrisonerAdd()
        {
            return View();
        }
        public IActionResult PrisonerAssign()
        {
            return View();
        }
        public IActionResult PrisonerEdit()
        {
            return View();
        }
        public IActionResult Offense()
        {
            if (UserController.LoggedIn)
            {
                ViewBag.Logged = true;
            }
            string[] links = { "OffenseAdd"
            };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
            return View();
        }
        public IActionResult OffenseAdd()
        {
            return View();
        }
        public IActionResult OffenseReport()
        {
            return View();
        }
        public IActionResult PrisonerList()
        {
            if (UserController.LoggedIn)
            {
                ViewBag.Logged = true;
            }
            string[] links = { "PrisonerAdd", "PrisonerAssign", "PrisonerEdit", "Offense"
            };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
            return View();
        }

        public static Dictionary<string, KeyValuePair<string, string>> MeniuItemDictionary = new Dictionary<string, KeyValuePair<string, string>>
        {
           
            {"PrisonerAdd", new KeyValuePair<string,string>("Prisoner","Kalinio registracija" )},
            {"PrisonerAssign", new KeyValuePair<string,string>("Prisoner","Kameros priskyrimas" )},
            {"PrisonerEdit", new KeyValuePair<string,string>("Prisoner","Kalinio redagavimas" )},
            {"Offense", new KeyValuePair<string,string>("Prisoner","Nusižengimai" )},
            {"OffenseAdd", new KeyValuePair<string,string>("Prisoner","Nusižengimo registravimas" )}
        };
    }
}