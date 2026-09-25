using ultimate_design_patterns_With_CSharp.Solid;
using static ultimate_design_patterns_With_CSharp.Solid.PaymentProcess;

namespace ultimate_design_patterns_With_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order DummyOrder = new Order
            {
                Name = "Dummy Order",
                TotalPrice = 1000
            };

            PaymentServices paymentServices = new PaymentServices(new MasterCardPayments());

            paymentServices.Pay(DummyOrder);
        }
    }
}
