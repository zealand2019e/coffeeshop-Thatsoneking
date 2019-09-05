using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            
            return 20;
        }
        public int discount;
        public abstract string Strength();
        public virtual float Percentage()
        {
            return 2;
        }
        public virtual int clAlcohol()
        {
            return 4;
        }
        public Coffee(int Discount) { discount = Discount; }
    }
}
