using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CvEntityCoreMvc.Models.Sinflar;

namespace CvEntityCoreMvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {         
            var deger = c.Yeteneklers.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YetenekEkle(Yetenekler y)
        {
            c.Yeteneklers.Add(y);
            c.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var deger = c.Yeteneklers.Find(id);
            c.Yeteneklers.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger = c.Yeteneklers.Find(id);
            return View("YetenekGetir",deger);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenekler y)
        {
            var deger = c.Yeteneklers.Find(y.id);
            deger.Aciklama = y.Aciklama;
            deger.Deger = y.Deger;
            c.SaveChanges();
            return RedirectToAction("index");
        }
    }
}