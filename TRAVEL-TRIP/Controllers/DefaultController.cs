using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRAVEL_TRIP.Models.classes;
using System.Web.Mvc;

namespace TRAVEL_TRIP.Controllers
{
    public class DefaultController : Controller
    {   Context db = new Context();
        // GET: Default
        public ActionResult Index()
        {
            
            
            return View();
        }
        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
            var values = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var values = db.Blogs.Where(x => x.ID == 7).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial3()
        {
            var values = db.Blogs.Take(10).ToList();

            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = db.Blogs.Take(3).ToList();

            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = db.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();

            return PartialView(values);
        }
        public PartialViewResult Partial6()
        {
            var values = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return PartialView(values);
        }
    }
}