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
    public class NotfunniesController : Controller
    {
        private memecontext db = new memecontext();

        // GET: Notfunnies
        public ActionResult Index()
        {
            return View(db.Notfunny.ToList());
        }

        // GET: Notfunnies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notfunny notfunny = db.Notfunny.Find(id);
            if (notfunny == null)
            {
                return HttpNotFound();
            }
            return View(notfunny);
        }

        // GET: Notfunnies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notfunnies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Price,CableType,Phone")] Notfunny notfunny)
        {
            if (ModelState.IsValid)
            {
                db.Notfunny.Add(notfunny);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notfunny);
        }

        // GET: Notfunnies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notfunny notfunny = db.Notfunny.Find(id);
            if (notfunny == null)
            {
                return HttpNotFound();
            }
            return View(notfunny);
        }

        // POST: Notfunnies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Price,CableType,Phone")] Notfunny notfunny)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notfunny).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notfunny);
        }

        // GET: Notfunnies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notfunny notfunny = db.Notfunny.Find(id);
            if (notfunny == null)
            {
                return HttpNotFound();
            }
            return View(notfunny);
        }

        // POST: Notfunnies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notfunny notfunny = db.Notfunny.Find(id);
            db.Notfunny.Remove(notfunny);
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
