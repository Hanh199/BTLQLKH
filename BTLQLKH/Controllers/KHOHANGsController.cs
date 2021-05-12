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
    public class KHOHANGsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();

        // GET: KHOHANGs
        public ActionResult Index()
        {
            return View(db.KHOHANGs.ToList());
        }

        // GET: KHOHANGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOHANG kHOHANG = db.KHOHANGs.Find(id);
            if (kHOHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHOHANG);
        }

        // GET: KHOHANGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KHOHANGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKho,Tenkho,SDT,Diachi,Thukho")] KHOHANG kHOHANG)
        {
            if (ModelState.IsValid)
            {
                db.KHOHANGs.Add(kHOHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kHOHANG);
        }

        // GET: KHOHANGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOHANG kHOHANG = db.KHOHANGs.Find(id);
            if (kHOHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHOHANG);
        }

        // POST: KHOHANGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKho,Tenkho,SDT,Diachi,Thukho")] KHOHANG kHOHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kHOHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kHOHANG);
        }

        // GET: KHOHANGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KHOHANG kHOHANG = db.KHOHANGs.Find(id);
            if (kHOHANG == null)
            {
                return HttpNotFound();
            }
            return View(kHOHANG);
        }

        // POST: KHOHANGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KHOHANG kHOHANG = db.KHOHANGs.Find(id);
            db.KHOHANGs.Remove(kHOHANG);
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
