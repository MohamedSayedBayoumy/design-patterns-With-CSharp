using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class PickupOrder : Order
    {
        public PickupOrder(int price, int countOfItems, int fees)
            : base(price, countOfItems, fees)
        {
        }

        public override double CalculateTotalPrice()
        {
            return base.Price;
        }
    }
}
