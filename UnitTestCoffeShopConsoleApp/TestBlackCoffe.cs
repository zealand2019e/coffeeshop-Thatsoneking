using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoffeShopConsoleApp
{
    [TestClass]
    public class UnitTestBlackCoffe
    {
        [TestMethod]
        public void TestPriceBlackCoffe()
        {
            //Arrange
            Black_Coffe black_Coffe = new Black_Coffe(5);

            //Act
            int actualPrice = black_Coffe.price();

            //Assert
            Assert.AreEqual(25, actualPrice);
            Assert.ThrowsException()
        }
        public void TestStrenghtBlackCoffe()
        {
            //Arrange
            Black_Coffe black_Coffe = new Black_Coffe(5);

            //Act
            string actualStrenght = black_Coffe.Strength();

            //Assert
            Assert.AreEqual("Strong", actualStrenght);

        }
        
    }
}
