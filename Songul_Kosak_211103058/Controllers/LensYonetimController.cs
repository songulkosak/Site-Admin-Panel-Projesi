using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Songul_Kosak_211103058.DAL;

namespace Songul_Kosak_211103058.Controllers
{
    public class LensYonetimController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: LensYonetim
        public ActionResult Index()
        {
            return View(db.Lens.ToList());
        }

        // GET: LensYonetim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lens lens = db.Lens.Find(id);
            if (lens == null)
            {
                return HttpNotFound();
            }
            return View(lens);
        }

        // GET: LensYonetim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LensYonetim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LensId,LensResimYolu,LensÜstYazi,ResimSira")] Lens lens)
        {
            if (ModelState.IsValid)
            {
                db.Lens.Add(lens);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lens);
        }

        // GET: LensYonetim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lens lens = db.Lens.Find(id);
            if (lens == null)
            {
                return HttpNotFound();
            }
            return View(lens);
        }

        // POST: LensYonetim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LensId,LensResimYolu,LensÜstYazi,ResimSira")] Lens lens)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lens).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lens);
        }

        // GET: LensYonetim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lens lens = db.Lens.Find(id);
            if (lens == null)
            {
                return HttpNotFound();
            }
            return View(lens);
        }

        // POST: LensYonetim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lens lens = db.Lens.Find(id);
            db.Lens.Remove(lens);
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
