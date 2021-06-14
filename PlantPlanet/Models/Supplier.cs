using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "יש להזין שם חברה")]
        [Display(Name = "שם החברה")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "יש להזין מספר טלפון")]
        [Display(Name = "מספר טלפון")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "יש להזין מייל")]
        [Display(Name = "מייל")]
        public string Email { get; set; }

        [Display(Name = "רשימת מוצרים")]
        public List<Product> SuppliedProducts { get; set; }
    }
}
