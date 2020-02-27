using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myapp.DAL;
using myapp.Models;

namespace myapp.Controllers
{
    public class ShinbreakersController : Controller
    {
        private memecontext db = new memecontext();

        // GET: Shinbreakers
        public ActionResult Index()
        {
            return View(db.Shinbreaker.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDisplay([Bind(Include = "ID,Joke,FunnyLevel,Rating")] Shinbreaker shinbreaker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shinbreaker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Display");
            }
            return View(shinbreaker);
        }

        // GET: Student/Edit/5
        public ActionResult EditDisplay(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shinbreaker shinbreaker = db.Shinbreaker.Find(id);
            if (shinbreaker == null)
            {
                return HttpNotFound();
            }
            return View(shinbreaker);
        }

        // GET: Shinbreakers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shinbreaker shinbreaker = db.Shinbreaker.Find(id);
            if (shinbreaker == null)
            {
                return HttpNotFound();
            }
            return View(shinbreaker);
        }

        // GET: Shinbreakers/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Display()
        {
            return View(db.Shinbreaker.ToList());
        }
        // POST: Shinbreakers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FunnyLevel,Joke,Rating")] Shinbreaker shinbreaker)
        {
            if (ModelState.IsValid)
            {
                db.Shinbreaker.Add(shinbreaker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shinbreaker);
        }

        // GET: Shinbreakers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shinbreaker shinbreaker = db.Shinbreaker.Find(id);
            if (shinbreaker == null)
            {
                return HttpNotFound();
            }
            return View(shinbreaker);
        }

        // POST: Shinbreakers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FunnyLevel,Joke,Rating")] Shinbreaker shinbreaker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shinbreaker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shinbreaker);
        }

        // GET: Shinbreakers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shinbreaker shinbreaker = db.Shinbreaker.Find(id);
            if (shinbreaker == null)
            {
                return HttpNotFound();
            }
            return View(shinbreaker);
        }

        // POST: Shinbreakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shinbreaker shinbreaker = db.Shinbreaker.Find(id);
            db.Shinbreaker.Remove(shinbreaker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
