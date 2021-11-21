using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proekt_v2.Models;

namespace Proekt_v2.Controllers
{
    public class InRepairsController : Controller
    {
        private ServizDBContext db = new ServizDBContext();

        // GET: InRepairs
        public ActionResult Index(string searchString)
        {
            var inRepair = db.InRepair.Include(i => i.Services);

            var item = from i in db.InRepair
                       select i;
            if (!String.IsNullOrEmpty(searchString))
            {
                item = item.Where(s => s.ProductName.Contains(searchString));
            }

            return View(item);
        }

        // GET: InRepairs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InRepair inRepair = db.InRepair.Find(id);
            if (inRepair == null)
            {
                return HttpNotFound();
            }
            return View(inRepair);
        }

        // GET: InRepairs/Create
        public ActionResult Create()
        {
            ViewBag.ServicesId = new SelectList(db.Services, "Id", "Title");
            return View();
        }

        // POST: InRepairs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ServicesId,ProductName,ClientName,ProductNumber,TotalPrice,Received,Returning")] InRepair inRepair)
        {
            if (ModelState.IsValid)
            {
                db.InRepair.Add(inRepair);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ServicesId = new SelectList(db.Services, "Id", "Title", inRepair.ServicesId);
            return View(inRepair);
        }

        // GET: InRepairs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InRepair inRepair = db.InRepair.Find(id);
            if (inRepair == null)
            {
                return HttpNotFound();
            }
            ViewBag.ServicesId = new SelectList(db.Services, "Id", "Title", inRepair.ServicesId);
            return View(inRepair);
        }

        // POST: InRepairs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ServicesId,ProductName,ClientName,ProductNumber,TotalPrice,Received,Returning")] InRepair inRepair)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inRepair).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ServicesId = new SelectList(db.Services, "Id", "Title", inRepair.ServicesId);
            return View(inRepair);
        }

        // GET: InRepairs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InRepair inRepair = db.InRepair.Find(id);
            if (inRepair == null)
            {
                return HttpNotFound();
            }
            return View(inRepair);
        }

        // POST: InRepairs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InRepair inRepair = db.InRepair.Find(id);
            db.InRepair.Remove(inRepair);
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
