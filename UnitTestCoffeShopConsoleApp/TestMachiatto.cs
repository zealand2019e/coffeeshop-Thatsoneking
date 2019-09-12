using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoffeShopConsoleApp
{
    [TestClass]
    public class UnitTestMachiatto
    {
        [TestMethod]
        public void TestPriceMachiatto()
        {
            //Arrange
            Machiatto machiatto = new Machiatto(5);

            //Act
            int actualPrice = machiatto.price();

            //Assert
            Assert.AreEqual(25,actualPrice);
        }
        public void TestStrenghtMachiatto()
        {
            //Arrange
            Machiatto machiatto = new Machiatto(5);

            //Act
            string actualStrenght = machiatto.Strength();

            //Assert
            Assert.AreEqual("Medium", actualStrenght);
        }
    }
}
