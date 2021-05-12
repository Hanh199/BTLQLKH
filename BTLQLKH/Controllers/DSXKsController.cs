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
    public class DSXKsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();

        // GET: DSXKs
        public ActionResult Index()
        {
            var dSXKs = db.DSXKs.Include(d => d.HDXUATs).Include(d => d.KHOHANGs);
            return View(dSXKs.ToList());
        }

        // GET: DSXKs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSXK dSXK = db.DSXKs.Find(id);
            if (dSXK == null)
            {
                return HttpNotFound();
            }
            return View(dSXK);
        }

        // GET: DSXKs/Create
        public ActionResult Create()
        {
            ViewBag.MaHDX = new SelectList(db.HDXUATs, "MaHDX", "TenHDX");
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho");
            return View();
        }

        // POST: DSXKs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sophieuxuat,MaHDX,MaKho,TenMH,TenKH,Soluongban,Giaban,Ngayxuat,Nhanvienxuat")] DSXK dSXK)
        {
            if (ModelState.IsValid)
            {
                db.DSXKs.Add(dSXK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaHDX = new SelectList(db.HDXUATs, "MaHDX", "TenHDX", dSXK.MaHDX);
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", dSXK.MaKho);
            return View(dSXK);
        }

        // GET: DSXKs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSXK dSXK = db.DSXKs.Find(id);
            if (dSXK == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaHDX = new SelectList(db.HDXUATs, "MaHDX", "TenHDX", dSXK.MaHDX);
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", dSXK.MaKho);
            return View(dSXK);
        }

        // POST: DSXKs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sophieuxuat,MaHDX,MaKho,TenMH,TenKH,Soluongban,Giaban,Ngayxuat,Nhanvienxuat")] DSXK dSXK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dSXK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHDX = new SelectList(db.HDXUATs, "MaHDX", "TenHDX", dSXK.MaHDX);
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", dSXK.MaKho);
            return View(dSXK);
        }

        // GET: DSXKs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DSXK dSXK = db.DSXKs.Find(id);
            if (dSXK == null)
            {
                return HttpNotFound();
            }
            return View(dSXK);
        }

        // POST: DSXKs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DSXK dSXK = db.DSXKs.Find(id);
            db.DSXKs.Remove(dSXK);
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
