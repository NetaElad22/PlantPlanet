using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input Customer")]
        public Customer CustomerId { get; set; }

        [Required(ErrorMessage = "You must input Products")]
        public List<Product> Products { get; set; }

        public float OrderSumPayment { get; set; }

    }
}
