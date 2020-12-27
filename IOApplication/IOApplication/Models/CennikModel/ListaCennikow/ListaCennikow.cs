using IOApplication.Models.CennikModel.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Models.CennikModel.ListaCennikow
{
    //singleton!!!!
    public class ListaCennikow
    {
        private List<Cennik> listaCennikow = new List<Cennik>();
        public int counter = 0;
        private static ListaCennikow instance = null;
        public static ListaCennikow GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ListaCennikow();
                return instance;
            }
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