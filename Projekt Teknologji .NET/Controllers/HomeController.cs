using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Projekt_Teknologji.NET.Models;

namespace Projekt_Teknologji.NET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(Contact c)
        {
            if (ModelState.IsValid)
            {
                string subject = c.Subjekti;
                string body = "Derguesi: " + c.Emri + ", Email: " + c.Email + ", Mesazhi: " + c.Mesazhi;
                string email_rec = "admirimkorici05@gmail.com";

                WebMail.Send(email_rec, subject, body, null, null, null, true, null, null, null, null, null, null);
                ViewBag.Msg = "Mesazhi u dergua!";
            }
            ModelState.Clear();

            return View();
        }
    }
}