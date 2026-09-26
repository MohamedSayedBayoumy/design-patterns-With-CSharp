using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid
{
    public class OrderModel
    {
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class PaymentModel
    {
        public string Type { get; set; }
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
