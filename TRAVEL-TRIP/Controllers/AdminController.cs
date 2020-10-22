using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRAVEL_TRIP.Models.classes;
namespace TRAVEL_TRIP.Controllers
{
    public class AdminController : Controller
    {
        Context db = new Context();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult BlogCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BlogCreate(Blog p)
        {
            db.Blogs.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult BlogDelete(int id)
        {
            var blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGet(int id)
        {
            var blog = db.Blogs.Find(id);
            return View("BlogGet", blog);
        }

        public  ActionResult BlogGuncelle(Blog p)
        {
            var blog = db.Blogs.Find(p.ID);
            blog.ACIKLAMA = p.ACIKLAMA;
            blog.BASLIK = p.BASLIK;
            blog.BLOGIMAGE = p.BLOGIMAGE;
            blog.TARIH = p.TARIH;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = db.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumDelete(int id)
        {
            var yorum = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(yorum);
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGet(int id)
        {
            var yorum = db.Yorumlars.Find(id);
            return View("YorumGet", yorum);
        }

        public ActionResult YorumGuncelle(Yorumlar p)
        {
            var yorum = db.Yorumlars.Find(p.ID);
            yorum.KULLANICIADI = p.KULLANICIADI;
            yorum.MAIL = p.MAIL;
            yorum.YORUM = p.YORUM;
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumDetay(int id)
        {
            var yorumdetay = db.Yorumlars.Find(id);
            return View("YorumDetay", yorumdetay);
        }
    }
}