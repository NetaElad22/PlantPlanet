using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Address
    {
        public string City { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int FloorNumber { get; set; }

        public int ApartmentNumber { get; set; }
    }
}
