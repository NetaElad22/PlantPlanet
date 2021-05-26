using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Product> SuppliedProducts { get; set; }

    }
}


