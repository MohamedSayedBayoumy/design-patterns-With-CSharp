using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class DeliveryOrder : Order, IClacOrderPrice
    {
        public DeliveryOrder(int price, int count, int fees) 
            : base(price, count, fees)
        {
        }

        public double CalculateTotalPrice()
        {
             return (base.Price * base.Count) + base.Fees;
        }
    }
}
