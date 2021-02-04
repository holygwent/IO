using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.Component
{
    //sprawdz namespace
    public abstract class Cennik
    {

        public abstract double CalculateCost();
        public abstract string GetName();
    }
}