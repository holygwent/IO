using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IOApplication.Models.CennikModel.Component;

namespace IOApplication.Models.CennikModel.ConcreteComponent
{
    public class Days180Component: Cennik
    {
        public override double CalculateCost()
        {
            return 70;
        }

        public override string GetName()
        {
            return "Karnet:180-dniowy wraz z zajęciami:";
        }
    }
}