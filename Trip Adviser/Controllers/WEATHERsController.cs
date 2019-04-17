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
    public class WEATHERsController : Controller
    {
        private tripAdviserEntities db = new tripAdviserEntities();

        // GET: WEATHERs
        public ActionResult Index()
        {
            var wEATHERs = db.WEATHERs.Include(w => w.PLACE);
            return View(wEATHERs.ToList());
        }

        // GET: WEATHERs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WEATHER wEATHER = db.WEATHERs.Find(id);
            if (wEATHER == null)
            {
                return HttpNotFound();
            }
            return View(wEATHER);
        }

        // GET: WEATHERs/Create
        public ActionResult Create()
        {
            ViewBag.PlacePlaceId = new SelectList(db.PLACEs, "PlaceId", "PlaceName");
            return View();
        }

        // POST: WEATHERs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeatherId,PlacePlaceId,Jan,Feb,Mar,Apr,May,June,July,Aug,Sep,Oct,Nov,Dcm,WeatherDesc,WeatherAvg")] WEATHER wEATHER)
        {
            if (ModelState.IsValid)
            {
                db.WEATHERs.Add(wEATHER);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlacePlaceId = new SelectList(db.PLACEs, "PlaceId", "PlaceName", wEATHER.PlacePlaceId);
            return View(wEATHER);
        }

        // GET: WEATHERs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WEATHER wEATHER = db.WEATHERs.Find(id);
            if (wEATHER == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlacePlaceId = new SelectList(db.PLACEs, "PlaceId", "PlaceName", wEATHER.PlacePlaceId);
            return View(wEATHER);
        }

        // POST: WEATHERs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeatherId,PlacePlaceId,Jan,Feb,Mar,Apr,May,June,July,Aug,Sep,Oct,Nov,Dcm,WeatherDesc,WeatherAvg")] WEATHER wEATHER)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wEATHER).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlacePlaceId = new SelectList(db.PLACEs, "PlaceId", "PlaceName", wEATHER.PlacePlaceId);
            return View(wEATHER);
        }

        // GET: WEATHERs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WEATHER wEATHER = db.WEATHERs.Find(id);
            if (wEATHER == null)
            {
                return HttpNotFound();
            }
            return View(wEATHER);
        }

        // POST: WEATHERs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WEATHER wEATHER = db.WEATHERs.Find(id);
            db.WEATHERs.Remove(wEATHER);
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
