using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace TrivieteKamera.Controllers
{
    public class NavigationController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            if (UserController.LoggedIn)
            {
                ViewBag.Logged = true;
            }
            else ViewBag.Logged = false;
            string[] links = { "SupplierList", "ScheduleCreate", "CafeteriaRateList", "OffenseReport",
                                "SupplyStats", "PrisonerList", "ZoneList", "Schedule", "SupplyList"
            };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
            return View();
        }

        public IActionResult Login()
        {
            string[] links = {  };
            ViewBag.MeniuItemDictionary = MeniuItemDictionary;
            ViewBag.MeniuItems = links;
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public static Dictionary<string, KeyValuePair<string, string>> MeniuItemDictionary = new Dictionary<string, KeyValuePair<string, string>>
        {
            {"SupplierList", new KeyValuePair<string,string>("Cafeteria","Tiekėjų Sąrašas") },
            {"CafeteriaRate", new KeyValuePair<string,string>("Cafeteria","Valgyklos Ivertinimas" )},
            {"SupplyStats", new KeyValuePair<string,string>("Cafeteria","Išteklių statistika" )},
            {"SupplyList", new KeyValuePair<string,string>("Cafeteria","Maisto atsargų sąrašas" )},
            {"SupplierRemove", new KeyValuePair<string,string>("Cafeteria","Tiekėjo šalinimas" )},
            {"SupplierAdd", new KeyValuePair<string,string>("Cafeteria","Tiekėjo pridėjimas" )},
            {"CafeteriaRateList", new KeyValuePair<string,string>("Cafeteria","Valgyklų įvertinimų sąrašas" )},
            {"SupplyAdd", new KeyValuePair<string,string>("Cafeteria","Maisto atsargų papildymas" )},
            {"ScheduleCreate", new KeyValuePair<string,string>("Schedule","Tvarkaraščio kurimas")},
            {"Schedule", new KeyValuePair<string,string>("Schedule","Tvarkaraštis" )},
            {"PrisonerAdd", new KeyValuePair<string,string>("Prisoner","Kalinio registracija" )},
            {"PrisonerAssign", new KeyValuePair<string,string>("Prisoner","Kameros priskyrimas" )},
            {"PrisonerEdit", new KeyValuePair<string,string>("Prisoner","Kalinio redagavimas" )},
            {"Offense", new KeyValuePair<string,string>("Prisoner","Nusižengimas" )},
            {"OffenseAdd", new KeyValuePair<string,string>("Prisoner","Nusižengimo registravimas" )},
            {"OffenseReport", new KeyValuePair<string,string>("Prisoner","Nusižengimo ataskaita")},
            {"PrisonerList", new KeyValuePair<string,string>("Prisoner","Kalinių sąrašas" )},
            {"ZoneEdit", new KeyValuePair<string,string>("Zone","Kalėjimo zonos redagavimas" )},
            {"ZoneAdd", new KeyValuePair<string,string>("Zone","Kalėjimo zonos kūrimas" )},
            {"ZoneList", new KeyValuePair<string,string>("Zone","Kalėjimo zonos" )}

        };

        
    }

}