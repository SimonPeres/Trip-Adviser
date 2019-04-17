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
    public class RESTAURANTsController : Controller
    {
        private tripAdviserEntities db = new tripAdviserEntities();

        // GET: RESTAURANTs
        public ActionResult Index()
        {
            return View(db.RESTAURANTs.ToList());
        }

        // GET: RESTAURANTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESTAURANT rESTAURANT = db.RESTAURANTs.Find(id);
            if (rESTAURANT == null)
            {
                return HttpNotFound();
            }
            return View(rESTAURANT);
        }

        // GET: RESTAURANTs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RESTAURANTs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResId,ResName,ResDesc,ResLocation")] RESTAURANT rESTAURANT)
        {
            if (ModelState.IsValid)
            {
                db.RESTAURANTs.Add(rESTAURANT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rESTAURANT);
        }

        // GET: RESTAURANTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESTAURANT rESTAURANT = db.RESTAURANTs.Find(id);
            if (rESTAURANT == null)
            {
                return HttpNotFound();
            }
            return View(rESTAURANT);
        }

        // POST: RESTAURANTs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResId,ResName,ResDesc,ResLocation")] RESTAURANT rESTAURANT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rESTAURANT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rESTAURANT);
        }

        // GET: RESTAURANTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESTAURANT rESTAURANT = db.RESTAURANTs.Find(id);
            if (rESTAURANT == null)
            {
                return HttpNotFound();
            }
            return View(rESTAURANT);
        }

        // POST: RESTAURANTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RESTAURANT rESTAURANT = db.RESTAURANTs.Find(id);
            db.RESTAURANTs.Remove(rESTAURANT);
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
