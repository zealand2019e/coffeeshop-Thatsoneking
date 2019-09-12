using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoffeShopConsoleApp
{
    [TestClass]
    public class UnitTestFlatWhite      
    {
        [TestMethod]
        public void TestPriceFlatWhite()
        {
            //Arrange
            FlatWhite flatWhite = new FlatWhite(5);

            //Act
            int actualPrice = flatWhite.price();

            //Assert
            Assert.AreEqual(35, actualPrice);
        }
        public void TestStrenghtFlatWhite()
        {
            //Arrange
            FlatWhite flatWhite = new FlatWhite(5);

            //Act
            string actualStrenght = flatWhite.Strength();

            //Assert
            Assert.AreEqual("Medium", actualStrenght);
        }
    }
}