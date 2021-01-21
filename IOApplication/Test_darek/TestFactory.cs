using IOApplication.Content.Csharp.Fabryka;
using IOApplication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_darek
{
    [TestClass]
    public class TestFactory
    {
        private SiłowniaEntities2 db = new SiłowniaEntities2();
        [TestMethod]
        
        public void Sprawdzanie_poprawnosci_danych_trenera_z_fabryki()
        {
            //Arange
            TrenerFactory fabryka = new TrenerFactory();
            string imie="Andrzej", nazwisko="Kwitek";


            //Act
            var TrenerMiesiaca = fabryka.CreatePracownik(TrenerPoID.Andrzej_Kwitek);
            //Assert
            Assert.AreEqual(imie,TrenerMiesiaca.Imie);
            Assert.AreEqual(nazwisko,TrenerMiesiaca.Nazwisko);


        }
        [TestMethod]

        public void Sprawdzanie_poprawnosci_danych_trenera_z_fabryki_v2()
        {
            //Arange
            DateTime zatrudnienie = new DateTime(2019, 06, 03);
            DateTime dzisiaj = DateTime.Now;
            TimeSpan roznica = dzisiaj - zatrudnienie;
            string test = $"Członek naszego zespołu już z nami {roznica.Days} dni!!!";



            //Act
            TrenerFactory fabryka = new TrenerFactory();
            var TrenerMiesiaca = fabryka.CreatePracownik(TrenerPoID.Andrzej_Kwitek);
            //Assert
            Assert.AreEqual(test, TrenerMiesiaca.StazPracy());


        }

    }
}
