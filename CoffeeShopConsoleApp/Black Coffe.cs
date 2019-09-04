using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Black_Coffe : Coffee
    {
        public override string Strength()
        {
            return "Strong";
        }
        public Black_Coffe(int Discount):base(Discount)
        {
            discount = Discount;
        }
        public override int price()
        {

            return base.price() + 5 ;

        }
    }
}
