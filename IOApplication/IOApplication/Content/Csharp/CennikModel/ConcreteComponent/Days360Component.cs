using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOApplication.Models.CennikModel.Component;

namespace IOApplication.Models.CennikModel.ConcreteComponent
{
    public class Days360Component : Cennik
    {
        public override double CalculateCost()
        {
            return 150;
        }

        public override string GetName()
        {
            return "Karnet:360-dniowy wraz z zajęciami:";
        }
    }
}