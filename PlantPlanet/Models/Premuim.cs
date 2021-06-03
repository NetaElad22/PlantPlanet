using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Premuim
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Customer Customer { get; set; }

        public const int DiscountPercentage = 10;

    }
}
