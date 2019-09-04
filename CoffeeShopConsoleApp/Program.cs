using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");
            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Black_Coffe(5),
                new Latte(2),
                new Machiatto(10),
                new FlatWhite(12)

            };
            List<Coffee> milkList = new List<Coffee>();
            {

           foreach (var coffee in orderList)
            {
                if (coffee is Milk) milkList.Add(coffee);
            }
            }

            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the " +coffee+ " is : "+ (coffee.price() - coffee.discount));
                Console.WriteLine("the Strength of " + coffee + "is : " + coffee.Strength());
            }
            foreach (var coffee in milkList)
            {
                Console.WriteLine("the Price of "+coffee+" is : " + (coffee.price() - coffee.discount));
                Console.WriteLine("the Strength of "+coffee+" is : " + coffee.Strength());
            }
        } }
}
