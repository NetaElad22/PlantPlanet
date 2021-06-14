using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class DeliveryType
    {
        public int DeliveryTypeId { get; set; }

        [Required(ErrorMessage = "יש להזין סוג משלוח")]
        [Display(Name = "סוג משלוח")]
        public string Type { get; set; }

        [Display(Name ="תוספת תשלום")]
        public int DeliveryCostAddition { get; set; } = 0;
    }
}
