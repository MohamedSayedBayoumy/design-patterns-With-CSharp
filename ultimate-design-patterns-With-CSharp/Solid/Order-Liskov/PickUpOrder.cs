using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class PickUpOrder : Order
    {
        public PickUpOrder(int price, int count, int fees) 
            : base(price, count, fees)
        {
        }
    }
}
