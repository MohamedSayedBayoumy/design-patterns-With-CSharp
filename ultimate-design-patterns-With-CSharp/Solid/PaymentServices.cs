using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid
{
    public class PaymentServices
    {
        public readonly IPaymentProcess PaymentProcess;

        public PaymentServices(IPaymentProcess paymentProcess)
        {
            PaymentProcess = paymentProcess;
        }

        public void Pay(OrderModel order)
        {
            PaymentProcess.Process(order);
        }
    }
}
