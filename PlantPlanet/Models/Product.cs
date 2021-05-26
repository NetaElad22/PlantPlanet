﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public SubCategory SubCategory { get; set; }

        public Category Category { get; set; }

        public int BuyingCost { get; set; }

        public float SellingPrice { get; set; }

        public string Color { get; set; }

        public int Size { get; set; }

        public int AvailableStock { get; set; }

        public string ImageURL { get; set; }

    }
}
