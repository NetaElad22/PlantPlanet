using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class CartProduct
    {
        public CartProduct(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public Product product { get; set; }
        public int quantity { get; set; }


    }
}
