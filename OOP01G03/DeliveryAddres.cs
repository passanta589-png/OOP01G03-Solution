using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01G03
{
    internal class DeliveryAddres
    {
        public string city { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }

        public DeliveryAddres(string city, string street, int buildingNumber)
        {
            city = city;
            street = street;
            buildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{buildingNumber} {street}, {city}";
        }
      

    }
}
