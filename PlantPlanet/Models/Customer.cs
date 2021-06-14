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

        [Required(ErrorMessage = "יש להזין שם פרטי")]
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "יש להזין שם משפחה")]
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [Display(Name = "הזמנות קודמות")]
        public List<Order> PreviousOrders { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "יש להזין מייל")]
        [Display(Name = "מייל")]
        public string Email { get; set; }

        [Required(ErrorMessage = "יש להזין מספר טלפון")]
        [Display(Name = "מספר טלפון")]
        public string PhoneNumber { get; set; }

        public User User { get; set; }

        public Boolean IsPremium { get; set; }

        [Required(ErrorMessage = "יש להזין עיר")]
        [Display(Name = "עיר")]
        public string City { get; set; }

        [Required(ErrorMessage = "יש להזין רחוב")]
        [Display(Name = "רחוב")]
        public string Street { get; set; }

        [Required(ErrorMessage = "יש להזין מספר בית")]
        [Display(Name = "מספר בית")]
        public string HouseNumber { get; set; }

        [Display(Name = "קומה")]
        public string FloorNumber { get; set; }

        [Display(Name = "מספר דירה")]
        public string FlatNumber { get; set; }

        [Required(ErrorMessage = "יש להזין מיקוד")]
        [Display(Name = "מיקוד")]
        public string ZipCode { get; set; }

    }
}
