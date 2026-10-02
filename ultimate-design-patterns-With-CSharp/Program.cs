using ultimate_design_patterns_With_CSharp.Solid;
using ultimate_design_patterns_With_CSharp.Solid.Order_Liskov;

namespace ultimate_design_patterns_With_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Open And Close
            OrderModel DummyOrder = new OrderModel
            {
                Name = "Dummy Order",
                TotalPrice = 1000
            };

            PaymentServices paymentServices = new PaymentServices(new MasterCardPayments());

            paymentServices.Pay(DummyOrder);
            #endregion

            #region Liskov
             

            #endregion

        }
    }
}
