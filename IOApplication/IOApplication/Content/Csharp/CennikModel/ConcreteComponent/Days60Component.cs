using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOApplication.Models.CennikModel.Component;

namespace IOApplication.Models.CennikModel.ConcreteComponent
{
    public class Days60Component : Cennik
    {
        public override double CalculateCost()
        {
            return 25;
        }

        public override string GetName()
        {
            return "Karnet:60-dniowy wraz z zajęciami:";
        }
    }
}