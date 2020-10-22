using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using TRAVEL_TRIP.Models.classes;
namespace TRAVEL_TRIP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context db = new Context();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = db.Admins.FirstOrDefault(x => x.KULLANICI == ad.KULLANICI && x.SIFRE == ad.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KULLANICI, false);
                Session["KULLANICI"] = bilgiler.KULLANICI.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }

        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }
    }
}