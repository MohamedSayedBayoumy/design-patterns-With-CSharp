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
            PickUpOrder childOrder = new PickUpOrder(100, 2, 10);
            Order parentOrder = new Order(100, 2, 10);

            Console.WriteLine($"Parent Price: {parentOrder.Price}");
            Console.WriteLine($"Child Price: {childOrder.Price}");

            #endregion

        }
    }
}
