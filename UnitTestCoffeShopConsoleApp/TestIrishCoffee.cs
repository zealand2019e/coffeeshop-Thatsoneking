using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoffeShopConsoleApp
{
    [TestClass]
    public class UnitTestIrishCoffee
    {
        [TestMethod]
        public void TestPriceIrishCoffee()
        {
            //Arrange
            IrishCoffee irishCoffee = new IrishCoffee(5);

            //Act
            int actualPrice = irishCoffee.price();

            //Assert
            Assert.AreEqual(75, actualPrice);
        }
        public void TestIrishCoffee()
        {
            //Arrange
            IrishCoffee irishCoffee = new IrishCoffee(5);

            //Act
            string actualStrenght = irishCoffee.Strength();

            //Assert
            Assert.AreEqual("Strong", actualStrenght);
        }
    }
}
