using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //do skopiowania usun jak skonczysz
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
    }
}