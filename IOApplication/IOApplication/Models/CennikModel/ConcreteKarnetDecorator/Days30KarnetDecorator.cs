using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ConcreteKarnetDecorator
{
    public class Days30KarnetDecorator: CennikDecorator
    {
        public Days30KarnetDecorator(Cennik cennik) : base(cennik)
        {

        }
        public override double CalculateCost()
        {
            return base.CalculateCost() + 15;
        }
        public override string GetName()
        {
            return base.GetName() + "30-dniowy wraz z zajęciami:";
        }
    }
}