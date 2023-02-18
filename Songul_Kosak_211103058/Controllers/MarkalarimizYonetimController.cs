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
    public class MarkalarimizYonetimController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: MarkalarimizYonetim
        public ActionResult Index()
        {
            return View(db.Markalarimiz.ToList());
        }

        // GET: MarkalarimizYonetim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Markalarimiz markalarimiz = db.Markalarimiz.Find(id);
            if (markalarimiz == null)
            {
                return HttpNotFound();
            }
            return View(markalarimiz);
        }

        // GET: MarkalarimizYonetim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarkalarimizYonetim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarkalarimizId,MarkaResimYolu,Sira")] Markalarimiz markalarimiz)
        {
            if (ModelState.IsValid)
            {
                db.Markalarimiz.Add(markalarimiz);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(markalarimiz);
        }

        // GET: MarkalarimizYonetim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Markalarimiz markalarimiz = db.Markalarimiz.Find(id);
            if (markalarimiz == null)
            {
                return HttpNotFound();
            }
            return View(markalarimiz);
        }

        // POST: MarkalarimizYonetim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarkalarimizId,MarkaResimYolu,Sira")] Markalarimiz markalarimiz)
        {
            if (ModelState.IsValid)
            {
                db.Entry(markalarimiz).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(markalarimiz);
        }

        // GET: MarkalarimizYonetim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Markalarimiz markalarimiz = db.Markalarimiz.Find(id);
            if (markalarimiz == null)
            {
                return HttpNotFound();
            }
            return View(markalarimiz);
        }

        // POST: MarkalarimizYonetim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Markalarimiz markalarimiz = db.Markalarimiz.Find(id);
            db.Markalarimiz.Remove(markalarimiz);
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
