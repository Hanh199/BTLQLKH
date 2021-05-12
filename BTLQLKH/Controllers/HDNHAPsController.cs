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
    public class HDNHAPsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();

        // GET: HDNHAPs
        public ActionResult Index()
        {
            return View(db.HDNHAPs.ToList());
        }

        // GET: HDNHAPs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDNHAP hDNHAP = db.HDNHAPs.Find(id);
            if (hDNHAP == null)
            {
                return HttpNotFound();
            }
            return View(hDNHAP);
        }

        // GET: HDNHAPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HDNHAPs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHDN,TenHD,TenMH,TenNCC,Soluongnhap,Gianhap,Ngaynhap,Nhanviennhap")] HDNHAP hDNHAP)
        {
            if (ModelState.IsValid)
            {
                db.HDNHAPs.Add(hDNHAP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hDNHAP);
        }

        // GET: HDNHAPs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDNHAP hDNHAP = db.HDNHAPs.Find(id);
            if (hDNHAP == null)
            {
                return HttpNotFound();
            }
            return View(hDNHAP);
        }

        // POST: HDNHAPs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHDN,TenHD,TenMH,TenNCC,Soluongnhap,Gianhap,Ngaynhap,Nhanviennhap")] HDNHAP hDNHAP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hDNHAP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hDNHAP);
        }

        // GET: HDNHAPs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDNHAP hDNHAP = db.HDNHAPs.Find(id);
            if (hDNHAP == null)
            {
                return HttpNotFound();
            }
            return View(hDNHAP);
        }

        // POST: HDNHAPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HDNHAP hDNHAP = db.HDNHAPs.Find(id);
            db.HDNHAPs.Remove(hDNHAP);
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
