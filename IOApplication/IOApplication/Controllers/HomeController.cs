﻿
using IOApplication.Models.CennikModel;
using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.ConcreteComponent;
using IOApplication.Models.CennikModel.ConcreteKarnetDecorator;
using IOApplication.Models.CennikModel.ConcreteZajeciaDecorator;
using IOApplication.Models.CennikModel.ListaCennikow;
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
            promocja2 = new JogaDecorator(promocja2);

        

            ListaCennikow lista = ListaCennikow.GetInstance;

            lista.DodajDoListy(promocja);
            lista.DodajDoListy(promocja2);
         

            return View(lista);
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