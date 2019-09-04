using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee , Milk
    {
        public override string Strength()
        {
            return "Medium";
        }
        public FlatWhite(int Discount) : base(Discount)
        {
            discount = Discount;
        }
        public override int price()
        {

            return base.price() + 15;
        }
        public int mlMilk()
        {
            return 20;
        }
    }
}
