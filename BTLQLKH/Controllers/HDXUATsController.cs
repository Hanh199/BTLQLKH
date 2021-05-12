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
    public class HDXUATsController : Controller
    {
        private BTLQLKHDbContext db = new BTLQLKHDbContext();

        // GET: HDXUATs
        public ActionResult Index()
        {
            return View(db.HDXUATs.ToList());
        }

        // GET: HDXUATs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDXUAT hDXUAT = db.HDXUATs.Find(id);
            if (hDXUAT == null)
            {
                return HttpNotFound();
            }
            return View(hDXUAT);
        }

        // GET: HDXUATs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HDXUATs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHDX,TenHDX,TenMH,TenKH,Soluongxuat,Giaban,Ngayxuat,Nhanvienxuat")] HDXUAT hDXUAT)
        {
            if (ModelState.IsValid)
            {
                db.HDXUATs.Add(hDXUAT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hDXUAT);
        }

        // GET: HDXUATs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDXUAT hDXUAT = db.HDXUATs.Find(id);
            if (hDXUAT == null)
            {
                return HttpNotFound();
            }
            return View(hDXUAT);
        }

        // POST: HDXUATs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHDX,TenHDX,TenMH,TenKH,Soluongxuat,Giaban,Ngayxuat,Nhanvienxuat")] HDXUAT hDXUAT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hDXUAT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hDXUAT);
        }

        // GET: HDXUATs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HDXUAT hDXUAT = db.HDXUATs.Find(id);
            if (hDXUAT == null)
            {
                return HttpNotFound();
            }
            return View(hDXUAT);
        }

        // POST: HDXUATs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HDXUAT hDXUAT = db.HDXUATs.Find(id);
            db.HDXUATs.Remove(hDXUAT);
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
