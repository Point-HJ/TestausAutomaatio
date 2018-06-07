using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Testaus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.TämäViikko = Utilities.DateParsing.GetWeekNumber(DateTime.Today);
            return View();
        }

        [HttpPost]
        public ActionResult Index(string pvm)
        {
            DateTime date = Utilities.DateParsing.ParseFinnishDate(pvm);
            ViewBag.Päivämäärä = date;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}