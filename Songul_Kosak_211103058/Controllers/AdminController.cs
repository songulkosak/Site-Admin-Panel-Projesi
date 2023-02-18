using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Songul_Kosak_211103058.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FileUpload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if(file != null && file.ContentLength > 0)
            {
                string path = Path.Combine(Server.MapPath("~/UploadedFiles"),Path.GetFileName(file.FileName));
                file.SaveAs(path);
                ViewBag.Mesaj = "/UploadedFiles/" + file.FileName;
            }
            
            return View();
        }
    }
}