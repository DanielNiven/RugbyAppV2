using RugbyApp.Models;
using RugbyApp.Models.Juniors;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RugbyApp.Controllers
{
    public class JuniorsController : Controller
    {
        private AppDbContext db = new AppDbContext();
        // GET: Juniors
        public ActionResult Index()
        {
            var juniors = db.Juniors.ToList();
            return View(juniors);
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JuniorsDetails juniors = db.Juniors.Find(id);
            if(juniors == null)
            {
                return HttpNotFound();
            }
            return View(juniors);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JuniorsDetails juniors)
        {
            if(ModelState.IsValid)
            {
                bool juniorsExists = db.Juniors.Where(j => j.FName.Equals(juniors.FName, System.StringComparison.InvariantCultureIgnoreCase) && j.LName.Equals(juniors.LName, System.StringComparison.InvariantCultureIgnoreCase)).Count() > 0;
                if(juniorsExists)
                {
                    ModelState.AddModelError(String.Empty, "Member already Exists in Database");
                    return View(juniors);
                }
                else
                {
                    db.Juniors.Add(juniors);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JuniorsDetails juniors = db.Juniors.Find(id);
            if(juniors == null)
            {
                return HttpNotFound();
            }
            return View(juniors);
        }
<<<<<<< HEAD
        [HttpPost]
=======

>>>>>>> 1a8a5c7d5e49e457c64246ad12ef631a9de6088b
        public ActionResult Edit(JuniorsDetails juniors)
        {
            if(ModelState.IsValid)
            {
                db.Entry(juniors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(juniors);
        }
<<<<<<< HEAD
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JuniorsDetails juniors = db.Juniors.Find(id);
            if (juniors == null)
            {
                return HttpNotFound();
            }
            return View(juniors);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            JuniorsDetails juniors = db.Juniors.Find(id);
            db.Juniors.Remove(juniors);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

=======
        
>>>>>>> 1a8a5c7d5e49e457c64246ad12ef631a9de6088b

    }
}