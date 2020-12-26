using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ConcreteKarnetDecorator
{
    public class Days360KarnetDecorator: CennikDecorator
    {
        public Days360KarnetDecorator(Cennik cennik) : base(cennik)
        {

        }
        public override double CalculateCost()
        {
            return base.CalculateCost() + 150;
        }
        public override string GetName()
        {
            return base.GetName() + "360-dniowy wraz z zajęciami:";
        }
    }
}