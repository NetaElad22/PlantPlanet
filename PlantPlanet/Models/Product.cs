using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        
        public string Description { get; set; }

        public SubCategory SubCategory { get; set; }

        public Category Category { get; set; }

        public float BuyingCost { get; set; }

        public float SellingPrice { get; set; }

        public string Supplier { get; set; }

        public float Discount { get; set; }

        public string Color { get; set; }

        public int Size { get; set; }

        // connect to Stock quantiity in stock class
        public int AvailableStock { get; set; }

        public string ImageURL { get; set; }

        public float NetIncome { get; set; }

        public int UnitsSold { get; set; }

    }
}
