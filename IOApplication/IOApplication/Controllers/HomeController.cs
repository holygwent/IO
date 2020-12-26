
using IOApplication.Models.CennikModel;
using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.ConcreteComponent;
using IOApplication.Models.CennikModel.ConcreteKarnetDecorator;
using IOApplication.Models.CennikModel.ConcreteZajeciaDecorator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Cennik promocja2 = new ConcreteComponent();
            promocja2 = new Days360KarnetDecorator(promocja2);
            promocja2 = new TaniecDecorator(promocja2);
            promocja2 = new FitnessDecorator(promocja2);

            Cennik[] cenniki = new Cennik[2];
            cenniki[0] = promocja;
            cenniki[1] = promocja2;
            
            var tab = new TablicaCennikow();

            tab.tablicaCennikow = cenniki;

            return View(tab);
        }

        private object TablicaCennikow()
        {
            throw new NotImplementedException();
        }

        //do skopiowania usun jak skonczysz
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
    }
}