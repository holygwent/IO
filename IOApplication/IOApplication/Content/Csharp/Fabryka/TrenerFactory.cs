using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOApplication.Content.Csharp.Fabryka
{
    public enum TrenerPoID
    {
        Antek_Bury = 1,
        Andrzej_Kwitek
    }
    public interface ITrener
    {

        string Imie { get; set; }
        string Nazwisko { get; set; }
        string StazPracy();
    }
    public class TrenerMiesiaca : ITrener
    {



        public string Imie { get; set; }


        public string Nazwisko { get; set; }
        public DateTime DataZatrudnienia { get; set; }


        public string StazPracy()
        {
            DateTime date2 = DateTime.Now;
            TimeSpan staz = date2 - DataZatrudnienia;
            return $"Członek naszego zespołu już z nami {staz.Days} dni!!!";
        }
    }
}