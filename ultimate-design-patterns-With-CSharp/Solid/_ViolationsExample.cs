using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid
{
    public class OrderManager
    {
        public void ProcessOrder(OrderModel order)
        {
            Console.WriteLine($"Processing order: {order.Name} now...");
        }

        public void ProcessPayment(OrderModel order, PaymentModel payment)
        {
            Console.WriteLine($"Processing payment of order: {order.Name}");
            Console.WriteLine($"Issuing payment for amount: {order.TotalPrice}");

            if (payment.Type.Equals("VISA", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Processing visa card payments...");
            }
            else if (payment.Type.Equals("MASTER_CARD", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Processing master card payments...");
            }
            else if (payment.Type.Equals("AMERICAN_EXPRESS", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Processing american express card payments...");
            }
            else
            {
                throw new NotSupportedException("Unsupported payment...");
            }
        }

        internal void SendEmailNotification(Customer customer, string message)
        {
            Console.WriteLine($"Sending email notification to: {customer.Email} with message: {message}");
        }
    }

   
}
