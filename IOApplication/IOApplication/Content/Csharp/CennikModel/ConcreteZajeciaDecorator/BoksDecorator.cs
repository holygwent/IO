using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ConcreteZajeciaDecorator
{
    //sprawdz namespace
    public class BoksDecorator: CennikDecorator
    {
        public BoksDecorator(Cennik cennik) : base(cennik)
        {

        }
        public override double CalculateCost()
        {
            return base.CalculateCost() + 5;
        }
        public override string GetName()
        {
            return base.GetName() + " Boks,";
        }
    }
}