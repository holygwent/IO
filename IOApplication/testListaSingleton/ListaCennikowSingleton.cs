using IOApplication.Models.CennikModel.ListaCennikow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace testListaSingleton
{
    [TestClass]
    public class ListaCennikowSingleton
    {
        [TestMethod]
        public void TestSingletonLiczbaStworzonychObiketow()
        {
            //arrange 
            int counter = 1;
            //act
            ListaCennikow l1 = ListaCennikow.GetInstance;

            ListaCennikow l2 = ListaCennikow.GetInstance;

            //assert
            Assert.AreEqual(counter, l2.counter);
        }

        [TestMethod]
        public void TestSingletonObiektySame()
        {
            //arrange 
            ListaCennikow l1;
            ListaCennikow l2;
            //act
            l1 = ListaCennikow.GetInstance;
            l2 = ListaCennikow.GetInstance;

            //assert
            Assert.AreSame(l1, l2);
        }
    }
}
