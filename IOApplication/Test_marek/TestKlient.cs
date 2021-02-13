using IOApplication.Content.Csharp.FunkcjeStatyczne;
using IOApplication.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Test_marek
{
    [TestClass]
    public class TestKlient
    {
        private SiłowniaEntities2 db;
        [TestMethod]
        public void Test_Klient_Count_In_Database()
        {
            //arrange
            db = new SiłowniaEntities2();
            var lista = db.Klient.ToList<Klient>();
            int liczbaKlientow = 5;
            //act
            int testLiczbaKlientow = FunkcjeLINQ.CountKlient(lista);
            //assert
            Assert.AreEqual(liczbaKlientow, testLiczbaKlientow);
        }
        [TestMethod]
        public void Test_Klient_List_Null()
        {
            //arrange
            var lista = new List<Klient> { };
            int liczbaKlientow = 0;
            //act
            int testLiczbaKlientow = FunkcjeLINQ.CountKlient(lista);
            //assert
            Assert.AreEqual(liczbaKlientow, testLiczbaKlientow);
        }
        [TestMethod]
        public void Test_New_Klient_Count()
        {
            //arrange
            var klienci = new List<Klient> { new Klient { IdKlienta = 0, Imie = "Adam" }, new Klient { IdKlienta = 1, Imie = "Jan" } };
            int test = 2;
            //act
            int testLiczbaKlientow = FunkcjeLINQ.CountKlient(klienci);
            //assert
            Assert.AreEqual(test, testLiczbaKlientow);
        }
        [TestMethod]
        public void Test_Klient_Is_Not_Null()
        {
            //arrange
            var lista = new List<Klient> { null };
            //act
            int testLiczbaKlientow = FunkcjeLINQ.CountKlient(lista);
            //assert
            Assert.IsNotNull(testLiczbaKlientow);
            
        }
        [TestMethod]
        public void Test_Klient_Is_Null()
        {
            //arrange
            var lista = new List<Klient> { null };
            int liczbaKlientow = 0;
            //act
            int testLiczbaKlientow = FunkcjeLINQ.CountKlient(lista);
            //assert
            Assert.AreEqual(liczbaKlientow, testLiczbaKlientow);
        }
        [TestMethod]
        public void Test_New_Klient_Count_With_Null()
        {
            //arrange
            var klienci = new List<Klient> { new Klient { IdKlienta = 0, Imie = "Adam" }, null, new Klient { IdKlienta = 1, Imie = "Jan" } };
            int test = 2;
            //act
            int testLiczbaKlientow = FunkcjeLINQ.CountKlient(klienci);
            //assert
            Assert.AreEqual(test, testLiczbaKlientow);
        }
    }
}
