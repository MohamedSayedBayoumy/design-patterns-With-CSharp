using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class DeliveryOrder : Order, IDeliverable
    {
        public DeliveryOrder(int price, int countOfItems, int fees, AddewssModel address, List<AddewssModel> addresses)
            : base(price, countOfItems, fees)
        {
            Address = address;
            Addresses = addresses;
        }

        public AddewssModel Address { get; private set; }
        public List<AddewssModel> Addresses { get; set; }

        public override double CalculateTotalPrice()
        {
            return base.Price + base.Fees;
        }

        public void SetAddress()
        {
            if (Addresses == null || Addresses.Count == 0)
            {
                throw new ArgumentException("Addresses list is empty or null");
            }
            Address = Addresses[0];
        }
    }
}
