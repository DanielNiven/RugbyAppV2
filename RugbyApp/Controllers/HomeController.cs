using RugbyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RugbyApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Juniors table";
            var Juniors = db.Juniors;
            return View();
        }

        public ActionResult Results()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SkillsDevelopment()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TrainingRecords()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}