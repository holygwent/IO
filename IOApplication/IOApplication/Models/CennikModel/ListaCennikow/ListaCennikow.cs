
using IOApplication.Models.CennikModel.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ListaCennikow
{

    public class ListaCennikow
    {
    
        private List<Cennik> listaCennikow = new List<Cennik>();
     
     
     
        public void DodajDoListy(Cennik c)
        {
            listaCennikow.Add(c);
        }
        public List<Cennik> OdajListe()
        {
            return listaCennikow;
        }
    }
}