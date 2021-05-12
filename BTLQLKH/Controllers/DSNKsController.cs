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
    public class DSNKsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();

        // GET: DSNKs
        public ActionResult Index()
        {
            var dSNKs = db.DSNKs.Include(d => d.HDNHAPs).Include(d => d.KHOHANGs);
            return View(dSNKs.ToList());
        }

        // GET: DSNKs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSNK dSNK = db.DSNKs.Find(id);
            if (dSNK == null)
            {
                return HttpNotFound();
            }
            return View(dSNK);
        }

        // GET: DSNKs/Create
        public ActionResult Create()
        {
            ViewBag.MaHDN = new SelectList(db.HDNHAPs, "MaHDN", "TenHD");
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho");
            return View();
        }

        // POST: DSNKs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sophieunhap,MaHDN,MaKho,TenMH,TenNCC,Soluongnhap,Gianhap,Ngaynhap,Nhanviennhap")] DSNK dSNK)
        {
            if (ModelState.IsValid)
            {
                db.DSNKs.Add(dSNK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaHDN = new SelectList(db.HDNHAPs, "MaHDN", "TenHD", dSNK.MaHDN);
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", dSNK.MaKho);
            return View(dSNK);
        }

        // GET: DSNKs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSNK dSNK = db.DSNKs.Find(id);
            if (dSNK == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaHDN = new SelectList(db.HDNHAPs, "MaHDN", "TenHD", dSNK.MaHDN);
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", dSNK.MaKho);
            return View(dSNK);
        }

        // POST: DSNKs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sophieunhap,MaHDN,MaKho,TenMH,TenNCC,Soluongnhap,Gianhap,Ngaynhap,Nhanviennhap")] DSNK dSNK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dSNK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHDN = new SelectList(db.HDNHAPs, "MaHDN", "TenHD", dSNK.MaHDN);
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", dSNK.MaKho);
            return View(dSNK);
        }

        // GET: DSNKs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSNK dSNK = db.DSNKs.Find(id);
            if (dSNK == null)
            {
                return HttpNotFound();
            }
            return View(dSNK);
        }

        // POST: DSNKs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DSNK dSNK = db.DSNKs.Find(id);
            db.DSNKs.Remove(dSNK);
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
