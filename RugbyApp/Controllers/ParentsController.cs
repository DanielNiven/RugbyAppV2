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
    public class ParentsController : Controller
    {
        private AppDbContext db = new AppDbContext();
        // GET: Parents
        public ActionResult Index()
        {
            var parents = db.Parents.ToList();
            return View(parents);
        }

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentsDetails parents = db.Parents.Find(id);
            if(parents == null)
            {
                return HttpNotFound();
            }
            return View(parents);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParentsDetails parents)
        {
            if (ModelState.IsValid)
            {
                bool parentsExists = db.Parents.Where(p => p.p1FName.Equals(parents.p1FName, System.StringComparison.InvariantCultureIgnoreCase) && p.p1SName.Equals(parents.p1SName, System.StringComparison.InvariantCultureIgnoreCase)).Count() > 0;
                if (parentsExists)
                {
                    ModelState.AddModelError(String.Empty, "Member already Exists in Database");
                    return View(parents);
                }
                else
                {
                    db.Parents.Add(parents);
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
            ParentsDetails parents = db.Parents.Find(id);
            if (parents == null)
            {
                return HttpNotFound();
            }
            return View(parents);
        }
        [HttpPost]
        public ActionResult Edit(ParentsDetails parents)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parents).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parents);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParentsDetails parents = db.Parents.Find(id);
            if (parents == null)
            {
                return HttpNotFound();
            }
            return View(parents);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ParentsDetails parents = db.Parents.Find(id);
            db.Parents.Remove(parents);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}

