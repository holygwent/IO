using IOApplication.Models.CennikModel.Component;
using IOApplication.Models.CennikModel.ConcreteComponent;
using IOApplication.Models.CennikModel.ConcreteZajeciaDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_darek
{
    [TestClass]
    public class TestDecorator
    {
        [TestMethod]
        public void TestCalculateCost()
        {
            //arrange
            int koszt = 85;

            //act
            Cennik promocja = new Days180Component();
          
            promocja = new JogaDecorator(promocja);
            promocja = new BoksDecorator(promocja);
            promocja = new FitnessDecorator(promocja);
            //assert
            
            Assert.AreEqual(promocja.CalculateCost(), koszt);
        }
        [TestMethod]
        public void Test_Name()
        {
            //arrange
            string nazwa = "Karnet:180-dniowy wraz z zajęciami: Joga, Boks, Fitness,";
            //act
            Cennik promocja = new Days180Component();
         
            promocja = new JogaDecorator(promocja);
            promocja = new BoksDecorator(promocja);
            promocja = new FitnessDecorator(promocja);
            //assert
            Assert.AreEqual(promocja.GetName(), nazwa);
        }
        [TestMethod]
        public void Test_Type()
        {
            //arrange
            Cennik c = new Days180Component();
            FitnessDecorator test = new FitnessDecorator(c);
            //act
            Cennik promocja = new Days180Component();
          
            promocja = new JogaDecorator(promocja);
            promocja = new BoksDecorator(promocja);
            promocja = new FitnessDecorator(promocja);
            //assert
            Assert.IsInstanceOfType(promocja, test.GetType());//poprawne sa tego samego typu ,ale czy sa tym samym??

        }
        [TestMethod]
        public void Test_Istance_Is_Same()
        {
            //arrange
            Cennik c = new Days180Component();
            FitnessDecorator test = new FitnessDecorator(c);
            //act
            Cennik promocja = new Days180Component();
          
            promocja = new JogaDecorator(promocja);
            promocja = new BoksDecorator(promocja);
            promocja = new FitnessDecorator(promocja);
            //assert
            Assert.AreNotSame(promocja, test);//nie sa takie same :D
        }
    }
}
