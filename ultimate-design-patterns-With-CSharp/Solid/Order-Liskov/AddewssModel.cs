using System;
using System.Collections.Generic;
using System.Text;

namespace ultimate_design_patterns_With_CSharp.Solid.Order_Liskov
{
    internal class AddewssModel
    {
        public AddewssModel(int id, int streetNumber, string streetName, string city)
        {
            this.id = id;
            StreetNumber = streetNumber;
            StreetName = streetName;
            City = city;
        }

        public int id { get; set; }
        public int StreetNumber { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }
    }
}
