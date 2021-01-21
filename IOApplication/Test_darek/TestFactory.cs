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
       
        
    }
}
