using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Quantity
    {
        public int id;
        public int quantity;

        public Quantity(int id, int quantity)
        {
            this.id = id;
            this.quantity = quantity;
        }
    }
}