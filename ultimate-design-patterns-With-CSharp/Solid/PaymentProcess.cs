using System;
using System.Collections.Generic;
using System.Text;


namespace ultimate_design_patterns_With_CSharp.Solid
{


    #region Single Responsibility Principle
    //public class PaymentProcess
    //{
    //    public void ProcessPayment(Order order, PaymentModel payment)
    //    {
    //        Console.WriteLine($"Processing payment of order: {order.Name}");
    //        Console.WriteLine($"Issuing payment for amount: {order.TotalPrice}");
    //        if (payment.Type.Equals("VISA", StringComparison.OrdinalIgnoreCase))
    //        {
    //            Console.WriteLine("Processing visa card payments...");
    //        }
    //        else if (payment.Type.Equals("MASTER_CARD", StringComparison.OrdinalIgnoreCase))
    //        {
    //            Console.WriteLine("Processing master card payments...");
    //        }
    //        else if (payment.Type.Equals("AMERICAN_EXPRESS", StringComparison.OrdinalIgnoreCase))
    //        {
    //            Console.WriteLine("Processing american express card payments...");
    //        }
    //        else
    //        {
    //            throw new NotSupportedException("Unsupported payment...");
    //        }
    //    }
    #endregion

    // We Apply Single Responsibility Principle But we violate Open & Close Principle
    // we Solve it by creating an interface and implement it in different classes for each payment type
    // But How we violate Open & Close Principle ? Deal Open Region of Single Responsibility Principle and see the code,
    // if we want to add new payment type we have to modify the ProcessPayment method which is a violation of Open & Close Principle

    #region Open & Close Principls

    // Rember Open & Close Principls Explain Abstract and interface 
    // But we Take Decision to use each of them based on Case
    // in this Case we use interface because we want to implement it in different classes for each payment type

    public interface IPaymentProcess
    {
        public void Process(OrderModel order);
    }

    public class VisaCardPayments : IPaymentProcess
    {
        public void Process(OrderModel order)
        {
            Console.WriteLine("Processing visa card payments...");
        }
    }

    public class MasterCardPayments : IPaymentProcess
    {
        public void Process(OrderModel order)
        {
            Console.WriteLine("Processing master card payments...");
        }
    }
    #endregion
}

