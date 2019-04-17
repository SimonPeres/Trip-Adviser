using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trip_Adviser;

namespace Trip_Adviser.Controllers
{
    public class HOTELsController : Controller
    {
        private tripAdviserEntities db = new tripAdviserEntities();

        // GET: HOTELs
        public ActionResult Index()
        {
            return View(db.HOTELs.ToList());
        }

        // GET: HOTELs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOTEL hOTEL = db.HOTELs.Find(id);
            if (hOTEL == null)
            {
                return HttpNotFound();
            }
            return View(hOTEL);
        }

        // GET: HOTELs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HOTELs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HotelId,HotelName,HotelDesc,HotelLocation,IdealPrice")] HOTEL hOTEL)
        {
            if (ModelState.IsValid)
            {
                db.HOTELs.Add(hOTEL);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hOTEL);
        }

        // GET: HOTELs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOTEL hOTEL = db.HOTELs.Find(id);
            if (hOTEL == null)
            {
                return HttpNotFound();
            }
            return View(hOTEL);
        }

        // POST: HOTELs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HotelId,HotelName,HotelDesc,HotelLocation,IdealPrice")] HOTEL hOTEL)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hOTEL).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hOTEL);
        }

        // GET: HOTELs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HOTEL hOTEL = db.HOTELs.Find(id);
            if (hOTEL == null)
            {
                return HttpNotFound();
            }
            return View(hOTEL);
        }

        // POST: HOTELs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HOTEL hOTEL = db.HOTELs.Find(id);
            db.HOTELs.Remove(hOTEL);
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
