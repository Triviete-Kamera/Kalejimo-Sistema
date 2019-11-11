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
            string[] links = { "SupplierList", "ScheduleCreate" };
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

        public static Dictionary<string, string> MeniuItemDictionary = new Dictionary<string, string>
        {
            {"SupplierList", "Tiekėjų Sąrašas"},
            {"ScheduleCreate", "Tvarkaraščio kurimas"},
            {"CafeteriaRate", "Valgyklos Ivertinimas" },
            {"OffenseReport", "Nusižengimo ataskaita"},
            {"SupplyStats", "Išteklių statistika" },
            {"PrisonerList", "Kalinių sąrašas" },
            {"ZoneList", "Kalėjimo zonos" },
            {"Schedule", "Tvarkaraštis" },
            {"SupplyList", "Maisto atsargų sąrašas" },
            {"SupplierRemove", "Tiekėjo šalinimas" },
            {"SupplierAdd", "Tiekėjo pridėjimas" },
            {"CafeteriaRateList", "Valgyklų įvertinimų sąrašas" },
            {"PrisonerAdd", "Kalinio registracija" },
            {"PrisonerAssign", "Kameros priskyrimas" },
            {"PrisonerEdit", "Kalinio redagavimas" },
            {"Offense", "Nusižengimas" },
            {"OffenseAdd", "Nusižengimo registravimas" },
            {"ZoneEdit", "Kalėjimo zonos redagavimas" },
            {"ZoneAdd", "Kalėjimo zonos kūrimas" },
            {"SupplyAdd", "Maisto atsargų papildymas" }
            
        };
    }



}