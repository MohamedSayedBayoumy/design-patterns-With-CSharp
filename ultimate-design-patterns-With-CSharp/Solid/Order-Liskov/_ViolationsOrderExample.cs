using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class _ViolationsOrderExample
    {
        public int Price { get; set; }
        public int Count { get; set; }
        public int Fees { get; set; }

        public double CalculateTotalPrice()
        {
            return Price * Count + Fees;
        }
    }
}
