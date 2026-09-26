using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class Order
    {
        public Order(int price, int count, int fees)
        {
            Price = price;
            Count = count;
            Fees = fees;
        }

        public int Price { get; set; }
        public int Count { get; set; }
        public int Fees { get; set; } = 100;

    }
}
