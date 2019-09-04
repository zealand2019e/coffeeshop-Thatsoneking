using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    public class Machiatto : Coffee,Milk
    {
        public override int price()
        {
            return base.price() + 5;
        }
        public Machiatto(int Discount) : base(Discount)
        {
            discount = Discount;
        }
        public override string Strength()
        {
            return "Medium";
        }
        public int mlMilk()
        {
            return 40;
        }
    }
}
