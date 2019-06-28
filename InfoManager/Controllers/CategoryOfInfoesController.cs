using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InfoManager.Models;

namespace InfoManager.Controllers
{
    public class CategoryOfInfoesController : Controller
    {
        private InfoDBContext db = new InfoDBContext();

        // GET: CategoryOfInfoes
        public ActionResult Index()
        {
            return View(db.CategoryOfInfos.ToList());
        }

        // GET: CategoryOfInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryOfInfo categoryOfInfo = db.CategoryOfInfos.Find(id);
            if (categoryOfInfo == null)
            {
                return HttpNotFound();
            }
            return View(categoryOfInfo);
        }

        // GET: CategoryOfInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryOfInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryOfInfoID,Description")] CategoryOfInfo categoryOfInfo)
        {
            if (ModelState.IsValid)
            {
                db.CategoryOfInfos.Add(categoryOfInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryOfInfo);
        }

        // GET: CategoryOfInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryOfInfo categoryOfInfo = db.CategoryOfInfos.Find(id);
            if (categoryOfInfo == null)
            {
                return HttpNotFound();
            }
            return View(categoryOfInfo);
        }

        // POST: CategoryOfInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryOfInfoID,Description")] CategoryOfInfo categoryOfInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryOfInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryOfInfo);
        }

        // GET: CategoryOfInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryOfInfo categoryOfInfo = db.CategoryOfInfos.Find(id);
            if (categoryOfInfo == null)
            {
                return HttpNotFound();
            }
            return View(categoryOfInfo);
        }

        // POST: CategoryOfInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryOfInfo categoryOfInfo = db.CategoryOfInfos.Find(id);
            db.CategoryOfInfos.Remove(categoryOfInfo);
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
