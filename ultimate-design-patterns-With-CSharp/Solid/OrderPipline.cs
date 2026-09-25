using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid
{
    class OrderPipline
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Processing order: {order.Name} now...");
        }
    }
}
