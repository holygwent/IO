using IOApplication.Models.CennikModel.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ConcreteComponent
{
    public class ConcreteComponent:Cennik
    {
        public override double CalculateCost()
        {
            return 0;
        }

        public override string GetName()
        {
            return "Karnet:";
        }
    }
}