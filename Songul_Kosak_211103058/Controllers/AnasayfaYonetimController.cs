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
    public class AnasayfaYonetimController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: AnasayfaYonetim
        public ActionResult Index()
        {
            return View(db.Anasayfa.ToList());
        }

        // GET: AnasayfaYonetim/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anasayfa anasayfa = db.Anasayfa.Find(id);
            if (anasayfa == null)
            {
                return HttpNotFound();
            }
            return View(anasayfa);
        }

        // GET: AnasayfaYonetim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnasayfaYonetim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnasayfaId,UstResimYolu,OrtaBaslik,AraResim,BizKimizYazisi,BizKimizBaslik,ButonYazi,AltResimYolu,AltResimBaslik,AltResimYazi")] Anasayfa anasayfa)
        {
            if (ModelState.IsValid)
            {
                db.Anasayfa.Add(anasayfa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anasayfa);
        }

        // GET: AnasayfaYonetim/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anasayfa anasayfa = db.Anasayfa.Find(id);
            if (anasayfa == null)
            {
                return HttpNotFound();
            }
            return View(anasayfa);
        }

        // POST: AnasayfaYonetim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnasayfaId,UstResimYolu,OrtaBaslik,AraResim,BizKimizYazisi,BizKimizBaslik,ButonYazi,AltResimYolu,AltResimBaslik,AltResimYazi")] Anasayfa anasayfa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anasayfa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anasayfa);
        }

        // GET: AnasayfaYonetim/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anasayfa anasayfa = db.Anasayfa.Find(id);
            if (anasayfa == null)
            {
                return HttpNotFound();
            }
            return View(anasayfa);
        }

        // POST: AnasayfaYonetim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anasayfa anasayfa = db.Anasayfa.Find(id);
            db.Anasayfa.Remove(anasayfa);
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
