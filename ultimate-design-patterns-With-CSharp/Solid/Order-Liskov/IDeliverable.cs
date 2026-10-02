using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal interface IDeliverable
    {
        public AddewssModel Address { get; }
        public List<AddewssModel> Addresses { get; set; }

        public void SetAddress();
    }
}
