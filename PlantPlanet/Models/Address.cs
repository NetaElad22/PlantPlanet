using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        [Required(ErrorMessage = "יש להזין עיר")]
        [Display(Name = "עיר")]
        public string City { get; set; }

        [Required(ErrorMessage = "יש להזין רחוב")]
        [Display(Name = "רחוב")]
        public string Street { get; set; }

        [Required(ErrorMessage = "יש להזין מספר בית")]
        [Display(Name = "מספר בית")]
        public int HouseNumber { get; set; }

        [Display(Name = "מספר קומה")]
        public int FloorNumber { get; set; }

        [Display(Name = "מספר דירה")]
        public int ApartmentNumber { get; set; }

        [Required(ErrorMessage = "יש להזין מיקוד")]
        [Display(Name = "מיקוד")]
        public int Zipcode { get; set; }

        [Display(Name = "הערות לשליח")]
        public string ExtraInfo { get; set; }
    }
}
