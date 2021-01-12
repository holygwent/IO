using IOApplication.Models;
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
    public class TrenerMiesiaca : ITrener //produkt
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
    public class PracownikFactory
    {
        private SiłowniaEntities2 db = new SiłowniaEntities2();

        public ITrener CreatePracownik(TrenerPoID pracownikID)
        {
            switch (pracownikID)
            {
                case TrenerPoID.Antek_Bury:
                    return DajPracownikMiesiaca((int)TrenerPoID.Antek_Bury);

                case TrenerPoID.Andrzej_Kwitek:
                    return DajPracownikMiesiaca((int)TrenerPoID.Andrzej_Kwitek);

                default:
                    throw new ArgumentException();
            }
        }


        private ITrener DajPracownikMiesiaca(int id)
        {
            TrenerMiesiaca trenerMiesiaca = new TrenerMiesiaca();
            var collection = db.Trener.Where(x => x.IdTrener == id);
            foreach (var item in collection)
            {

                trenerMiesiaca.Imie = item.Imie;
                trenerMiesiaca.Nazwisko = item.Nazwisko;
                trenerMiesiaca.DataZatrudnienia = item.DataZatrudnienia;
            }
            return trenerMiesiaca;
        }


    }





}