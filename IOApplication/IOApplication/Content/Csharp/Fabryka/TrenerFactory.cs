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
}