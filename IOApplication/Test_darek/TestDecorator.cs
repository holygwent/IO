using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.ConcreteComponent;
using IOApplication.Models.CennikModel.ConcreteKarnetDecorator;
using IOApplication.Models.CennikModel.ConcreteZajeciaDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_darek
{
    [TestClass]
    public class TestDecorator
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int kosz = 85;
            string nazwa = "Karnet:180-dniowy wraz z zajęciami: Joga, Boks, Fitness,";
            //act
            Cennik promocja = new ConcreteComponent();
            promocja = new Days180KarnetDecorator(promocja);
            promocja = new JogaDecorator(promocja);
            promocja = new BoksDecorator(promocja);
            promocja = new FitnessDecorator(promocja);
            //assert
            Assert.AreEqual(promocja.GetName(), nazwa);
            Assert.AreEqual(promocja.CalculateCost(), kosz);
        }
    }
}
