using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt_Teknologji.NET.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AfishoEmrin(string emri, string mbiemri)
        {
            string msg;
            msg = String.Format("Emri eshte " + emri + " Mbiemri eshte " + mbiemri);
            return Content(msg);
        }
    }
}