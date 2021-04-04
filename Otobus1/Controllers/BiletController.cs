using Otobus1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Otobus1.Controllers
{
    public class BiletController : Controller
    {
        // GET: Bilet
        BiletSatısEntities db = new BiletSatısEntities();
        [Authorize]
        public ActionResult Index()
        {
            var list = db.Bilet.ToList();
            return View(list);
        }

        [Authorize(Roles = "A")]
        public ActionResult Ekle()
        {

            List<SelectListItem> deger1 = (from x in db.Kategori.ToList()

                                           select new SelectListItem
                                           {
                                               Text = x.Ad,
                                               Value = x.Id.ToString()
                                           }).ToList();
            ViewBag.ktgr = deger1;
            return View();
        }
        [Authorize(Roles = "A")]
        [HttpPost]
        public ActionResult Ekle(Bilet ekle)
        {
            db.Bilet.Add(ekle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "A")]
        public ActionResult Sil(int id)
        {
            var urun = db.Bilet.Find(id);
            db.Bilet.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        

    }
}