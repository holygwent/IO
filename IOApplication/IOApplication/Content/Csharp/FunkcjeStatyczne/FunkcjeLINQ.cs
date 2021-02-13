using IOApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Content.Csharp.FunkcjeStatyczne
{
    public static class FunkcjeLINQ
    {
        public static int CountKlient(List<Klient> db)
        {

            var count = db.Where(x => x!=null).Count();
            return count;

        }
    }
}