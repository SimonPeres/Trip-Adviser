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
    public class PLACEsController : Controller
    {
        private tripAdviserEntities db = new tripAdviserEntities();

        // GET: PLACEs
        public ActionResult Index()
        {
            //var place = from p in db.PLACEs
            //            select p;
           // if (!String.IsNullOrEmpty(searching)) {
          //      place = place.Where(p => p.PlaceName.Contains(searching));
        //    }
            //return View(place.ToList());

            return View();
        }
        public ActionResult SearchPlace(string searching)
        {
            return View(db.PLACEs.Where(x=>x.PlaceName.Contains(searching)||searching==null));
        }

        // GET: PLACEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLACE pLACE = db.PLACEs.Find(id);
            if (pLACE == null)
            {
                return HttpNotFound();
            }
            return View(pLACE);
        }

        // GET: PLACEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PLACEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlaceId,PlaceName,PlaceDesc,PlaceDistance,PlaceLocation,BestTime,IdealStay")] PLACE pLACE)
        {
            if (ModelState.IsValid)
            {
                db.PLACEs.Add(pLACE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pLACE);
        }

        // GET: PLACEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLACE pLACE = db.PLACEs.Find(id);
            if (pLACE == null)
            {
                return HttpNotFound();
            }
            return View(pLACE);
        }

        // POST: PLACEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlaceId,PlaceName,PlaceDesc,PlaceDistance,PlaceLocation,BestTime,IdealStay")] PLACE pLACE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pLACE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pLACE);
        }

        // GET: PLACEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLACE pLACE = db.PLACEs.Find(id);
            if (pLACE == null)
            {
                return HttpNotFound();
            }
            return View(pLACE);
        }

        // POST: PLACEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PLACE pLACE = db.PLACEs.Find(id);
            db.PLACEs.Remove(pLACE);
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
