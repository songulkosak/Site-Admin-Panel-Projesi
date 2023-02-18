using Songul_Kosak_211103058.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Songul_Kosak_211103058.Controllers
{
    public class HomeController : Controller
    {
        DatabaseModel db = new DatabaseModel();
        // GET: Home
        public ActionResult Index()
        {

            var anasayfaBilgileri = db.Anasayfa.FirstOrDefault();
            return View(anasayfaBilgileri);
        }
        public ActionResult Iletisim()
        {
            var iletisimbilgi = db.Iletisim.FirstOrDefault();
            return View(iletisimbilgi);
        }
        public ActionResult Markalarimiz()
        {
            
            var markabilgi = db.Markalarimiz.OrderBy(h => h.Sira).ToList();
            return View(markabilgi);
        }
        public ActionResult Lens()
        {
            var lensbilgi = db.Lens.OrderBy(h => h.ResimSira).ToList();
            return View(lensbilgi);
        }


    }
}