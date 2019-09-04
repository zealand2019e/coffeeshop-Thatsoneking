using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Latte  : Coffee, Milk
    {
        public override int price()
        {
            
            return base.price()*2;

        }
        public Latte(int Discount) : base(Discount)
        {
            discount = Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }
}
