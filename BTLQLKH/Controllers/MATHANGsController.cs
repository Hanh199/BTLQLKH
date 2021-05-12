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
    public class MATHANGsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();

        // GET: MATHANGs
        public ActionResult Index()
        {
            var mATHANGs = db.MATHANGs.Include(m => m.KHOHANGs);
            return View(mATHANGs.ToList());
        }

        // GET: MATHANGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATHANG mATHANG = db.MATHANGs.Find(id);
            if (mATHANG == null)
            {
                return HttpNotFound();
            }
            return View(mATHANG);
        }

        // GET: MATHANGs/Create
        public ActionResult Create()
        {
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho");
            return View();
        }

        // POST: MATHANGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaMH,TenMH,SLton,DVT,Gianhap,MaNCC,MaKho,Ghichu")] MATHANG mATHANG)
        {
            if (ModelState.IsValid)
            {
                db.MATHANGs.Add(mATHANG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", mATHANG.MaKho);
            return View(mATHANG);
        }

        // GET: MATHANGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATHANG mATHANG = db.MATHANGs.Find(id);
            if (mATHANG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", mATHANG.MaKho);
            return View(mATHANG);
        }

        // POST: MATHANGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaMH,TenMH,SLton,DVT,Gianhap,MaNCC,MaKho,Ghichu")] MATHANG mATHANG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mATHANG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKho = new SelectList(db.KHOHANGs, "MaKho", "Tenkho", mATHANG.MaKho);
            return View(mATHANG);
        }

        // GET: MATHANGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MATHANG mATHANG = db.MATHANGs.Find(id);
            if (mATHANG == null)
            {
                return HttpNotFound();
            }
            return View(mATHANG);
        }

        // POST: MATHANGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            MATHANG mATHANG = db.MATHANGs.Find(id);
            db.MATHANGs.Remove(mATHANG);
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
