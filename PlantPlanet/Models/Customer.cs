using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PlantPlanet.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 5)]
        [Required(ErrorMessage = "You must input Address")]
        public string Address { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "You must input Email")]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public Boolean IsRegistered { get; set; }

        public List<Order> PreviousOrders { get; set; }
    }
}
