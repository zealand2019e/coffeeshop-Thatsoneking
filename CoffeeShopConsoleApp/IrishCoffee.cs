using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class IrishCoffee : Coffee , Alcohol
    {
        public override string Strength()
        {
            return "Strong";
        }
        public IrishCoffee(int Discount) : base(Discount)
        {
            discount = Discount;
        }
        public override int price()
        {

            return base.price() + 55;

        }
        public override float Percentage()
        {
            float Per = AlcPer();
            Per /= ClAlcohol();
            return Per;
        }
        public int ClAlcohol()
        {
            return 4;
        }
        public int AlcPer()
        {
            return 2;
        }
        
    }
}
