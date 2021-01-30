
using IOApplication.Content.Csharp.Fabryka;
using IOApplication.Models.CennikModel.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ListaCennikow
{
    //sprawdz namespace

    public class ListaCennikow
    {
    
        private List<Cennik> listaCennikow = new List<Cennik>();

        public ITrener trenerMiesiaca;

        public void DodajTreneraMiesiaca(ITrener trener)
        {
            trenerMiesiaca = trener;
        }


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