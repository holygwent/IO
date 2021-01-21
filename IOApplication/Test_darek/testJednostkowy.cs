using IOApplication.Content.Csharp.Fabryka;

using IOApplication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Test_darek
{
    [TestClass]
    public class testJednostkowy
    {
        private SiłowniaEntities2 db = new SiłowniaEntities2();

       
        [TestMethod]
        public void Poprawnosc_liczenia_roznicy_miedzy_datami()
        {
            //Arrange
            DateTime zatrudnienie = new DateTime(2019, 06, 03);
            DateTime dzisiaj = DateTime.Now;
            TimeSpan roznica = dzisiaj - zatrudnienie;
            string test = $"Członek naszego zespołu już z nami {roznica.Days} dni!!!";
            //Act
            TrenerMiesiaca trener = new TrenerMiesiaca();
            trener.DataZatrudnienia=new DateTime(2019, 06, 03);

            //Assert
            Assert.AreEqual(test, trener.StazPracy());
        }
        [TestMethod]
        public void Poprawnosc_zlapania_wyjatku_dla_przyszlej_daty_zatrudnienia()
        {
            //Arrange
            DateTime zatrudnienie = new DateTime(2019, 06, 03);
            DateTime dzisiaj = DateTime.Now;
            TimeSpan roznica = dzisiaj - zatrudnienie;
            string test = $"Członek naszego zespołu już z nami {roznica.Days} dni!!!";
            //Act
            TrenerMiesiaca trener = new TrenerMiesiaca();
            trener.DataZatrudnienia = new DateTime(2023, 06, 03);

            //Assert
            Assert.ThrowsException<Exception>(()=>trener.StazPracy());
        }
        [TestMethod]
        public void Poprawnosc_wyciagniecia_danych_oraz_wprowadzenie_do_classy_dla_andrzej_kwitek()
        {
            //Arrange
            string tImie = "Andrzej";
            string tNazwisko = "Kwitek";
            //Act
            int id = 2;
            TrenerMiesiaca trenerMiesiaca = new TrenerMiesiaca();
            var collection = db.Trener.Where(x => x.IdTrener == id);
            foreach (var item in collection)
            {

                trenerMiesiaca.Imie = item.Imie;
                trenerMiesiaca.Nazwisko = item.Nazwisko;
                trenerMiesiaca.DataZatrudnienia = item.DataZatrudnienia;
            }
            //Assert
            Assert.AreEqual(tImie, trenerMiesiaca.Imie);
            Assert.AreEqual(tNazwisko, trenerMiesiaca.Nazwisko);
        }
      

    }
}
