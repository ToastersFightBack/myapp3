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
    public class FunniesController : Controller
    {
        private memecontext db = new memecontext();

        // GET: Funnies
        public ActionResult Index()
        {
            return View(db.Funny.ToList());
        }

        // GET: Funnies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funny funny = db.Funny.Find(id);
            if (funny == null)
            {
                return HttpNotFound();
            }
            return View(funny);
        }

        // GET: Funnies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funnies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VeryGood,Mouse,Headphones")] Funny funny)
        {
            if (ModelState.IsValid)
            {
                db.Funny.Add(funny);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funny);
        }

        // GET: Funnies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funny funny = db.Funny.Find(id);
            if (funny == null)
            {
                return HttpNotFound();
            }
            return View(funny);
        }

        // POST: Funnies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,VeryGood,Mouse,Headphones")] Funny funny)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funny).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funny);
        }

        // GET: Funnies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Funny funny = db.Funny.Find(id);
            if (funny == null)
            {
                return HttpNotFound();
            }
            return View(funny);
        }

        // POST: Funnies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funny funny = db.Funny.Find(id);
            db.Funny.Remove(funny);
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
