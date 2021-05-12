using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTLQLKH.Models;

namespace BTLQLKH.Controllers
{
    [Authorize(Roles = "admin")]
    public class TRANGCHUsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();
        //[Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View(db.TRANGCHUs.ToList());
        }

        // GET: TRANGCHUs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGCHU tRANGCHU = db.TRANGCHUs.Find(id);
            if (tRANGCHU == null)
            {
                return HttpNotFound();
            }
            return View(tRANGCHU);
        }

        // GET: TRANGCHUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRANGCHUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTT,Noidung")] TRANGCHU tRANGCHU)
        {
            if (ModelState.IsValid)
            {
                db.TRANGCHUs.Add(tRANGCHU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tRANGCHU);
        }

        // GET: TRANGCHUs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGCHU tRANGCHU = db.TRANGCHUs.Find(id);
            if (tRANGCHU == null)
            {
                return HttpNotFound();
            }
            return View(tRANGCHU);
        }

        // POST: TRANGCHUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTT,Noidung")] TRANGCHU tRANGCHU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRANGCHU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tRANGCHU);
        }

        // GET: TRANGCHUs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGCHU tRANGCHU = db.TRANGCHUs.Find(id);
            if (tRANGCHU == null)
            {
                return HttpNotFound();
            }
            return View(tRANGCHU);
        }

        // POST: TRANGCHUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TRANGCHU tRANGCHU = db.TRANGCHUs.Find(id);
            db.TRANGCHUs.Remove(tRANGCHU);
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
