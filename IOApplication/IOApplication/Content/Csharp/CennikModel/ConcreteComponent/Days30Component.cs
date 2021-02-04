using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOApplication.Models.CennikModel.Component;

namespace IOApplication.Models.CennikModel.ConcreteComponent
{
    public class Days30Component : Cennik
    {
        public override double CalculateCost()
        {
            return 15;
        }

        public override string GetName()
        {
            return "Karnet:30-dniowy wraz z zajęciami:";
        }
    }
}