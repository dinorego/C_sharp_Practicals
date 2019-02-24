using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemostrationMVC.Models;

namespace DemostrationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Personal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Personal(PersonalModel person)
        {
            int personId = person.PersonId;
            string name = person.Name;
            string gender = person.Gender;
            string city = person.City;

            return View();
        }



    }
}