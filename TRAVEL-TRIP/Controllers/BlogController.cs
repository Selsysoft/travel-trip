using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRAVEL_TRIP.Models.classes;
namespace TRAVEL_TRIP.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var blog = db.Blogs.ToList();
            by.Deger1 = db.Blogs.ToList();
            by.Deger3 = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return View(by);
        }
        
        public ActionResult BlogDetay(int id)
        {
            by.Deger1 = db.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = db.Yorumlars.Where(x => x.BLOGID == id).ToList();

            //var blogbul = db.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.value = id;

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            db.Yorumlars.Add(y);
            db.SaveChanges();
            return PartialView();
        }
    }
}