using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Stock
    {
        public int StockId { get; set; }

        [Required(ErrorMessage = "יש להזין מוצר")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public DateTime LastUpdatedQuantity { get; set; }

    }
}
