
using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.ConcreteComponent;
using IOApplication.Models.CennikModel.ConcreteKarnetDecorator;
using IOApplication.Models.CennikModel.ConcreteZajeciaDecorator;
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
            Cennik promocja = new ConcreteComponent();
            promocja = new Days180KarnetDecorator(promocja);
            promocja = new JogaDecorator(promocja);
            promocja = new BoksDecorator(promocja);
            promocja = new FitnessDecorator(promocja);
           

            return View(promocja);
        }
        //do skopiowania usun jak skonczysz
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
    }
}