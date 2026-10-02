using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal abstract class Order
    {
        protected Order(int price, int countOfItems, int fees)
        {
            Price = price;
            CountOfItems = countOfItems;
            Fees = fees;
        }

        public int Price { get; set; }
        public int CountOfItems { get; set; }

        public int Fees { get; set; }

        public abstract double CalculateTotalPrice();
    }
}
