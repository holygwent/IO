using IOApplication.Models.CennikModel.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.Decorator
{
    public class CennikDecorator :Cennik
    {
        protected Cennik _cennik;
        public CennikDecorator(Cennik cennik)
        {
            _cennik = cennik;
        }
        public override double CalculateCost()
        {
            return _cennik.CalculateCost();
        }
        public override string GetName()
        {
            return _cennik.GetName();
        }
    }
}