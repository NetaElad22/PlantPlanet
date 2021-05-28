using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Premuim
    {
        public int PremiumId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        // connects to Customer id in Customer class
        public int Customer { get; set; }

        public const int DiscountPercentage = 10;
    }
}
