using Otobus1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Otobus1.Controllers
{
    public class AccountController : Controller
    {
        BiletSatısEntities db = new BiletSatısEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
        public ActionResult Ticket()
        {

            return View();
        }
        /*[HttpPost]
        public ActionResult Ticket(Bilet b)
        {
            var bilgi = db.Bilet.FirstOrDefault(x => x.Ad == b.Ad && x.Aciklama == b.Aciklama);

            if (bilgi != null)
            {
                Session["Ad"] = bilgi.Ad.ToString();
                Session["Aciklama"] = bilgi.Aciklama.ToString();
                return RedirectToAction("Ticket", "Account");
            }
            else
            {
                ViewBag.hata = "Kullanıcı Adı Veya Şifre Hatalı.";
            }
            return View();
        }*/
        public ActionResult logOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public ActionResult Login(Kullanici p)
        {
            var bilgiler = db.Kullanici.FirstOrDefault(x => x.Email == p.Email && x.Parola == p.Parola);

            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Email, false);
                Session["Email"] = bilgiler.Email.ToString();
                Session["Ad"] = bilgiler.Ad.ToString();
                Session["Soyad"] = bilgiler.Soyad.ToString();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.hata = "Kullanıcı Adı Veya Şifre Hatalı.";
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Kullanici data)
        {
            db.Kullanici.Add(data);
            data.Rol = "U";
            db.SaveChanges();
            return RedirectToAction("Login", "Account");
        }

    }
}