using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Stock
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime lastUpdatedQuantity { get; set; }

    }
}
