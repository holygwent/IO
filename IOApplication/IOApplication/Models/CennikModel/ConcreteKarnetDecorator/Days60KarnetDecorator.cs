using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ConcreteKarnetDecorator
{
    public class Days60KarnetDecorator: CennikDecorator
    {
        public Days60KarnetDecorator(Cennik cennik) : base(cennik)
        {

        }
        public override double CalculateCost()
        {
            return base.CalculateCost() + 25;
        }
        public override string GetName()
        {
            return base.GetName() + "60-dniowy wraz z zajęciami:";
        }
    }
}