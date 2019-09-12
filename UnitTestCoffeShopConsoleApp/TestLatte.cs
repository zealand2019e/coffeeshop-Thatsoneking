using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoffeShopConsoleApp
{
    [TestClass]
    public class UnitTestLatte
    {
        [TestMethod]
        public void TestPriceLatte()
        {
            //Arrange
            Latte latte = new Latte(5);

            //Act
            int actualPrice = latte.price();

            //Assert
            Assert.AreEqual(40, actualPrice);
        }
        public void TestStrenghtLatte()
        {
            //Arrange
            Latte latte = new Latte(5);

            //Act
            string actualStrenght = latte.Strength();

            //Assert
            Assert.AreEqual("Weak", actualStrenght);
        }
    }
}
