using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRAVEL_TRIP.Models.classes;

namespace TRAVEL_TRIP.Controllers
{
    public class AboutController : Controller
    {
        Context db = new Context();
        // GET: About
        public ActionResult Index()
        {
            var values = db.Hakkimizdas.ToList();
            return View(values);
        }
    }
}