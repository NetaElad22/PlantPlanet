using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "יש להזין את מספר תעודת הזהות של העובד")]
        [Display(Name = "תעודת זהות")]
        public int TeudatZehut { get; set; }

        [Required(ErrorMessage = "יש להזין שם פרטי")]
        [Display(Name = "שם פרטי")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "יש להזין שם משפחה")]
        [Display(Name = "שם משפחה")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "יש להזין תאריך העסקה")]
        [Display(Name = "תאריך העסקה")]
        public DateTime StartDate { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "יש להזין מייל")]
        [Display(Name = "מייל")]
        public string Email { get; set; }

        [Required(ErrorMessage = "יש להזין מספר טלפון")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "יש להזין מספר טלפון נייד בלבד")]
        [Display(Name = "מספר טלפון")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "יש להזין את משכורת העובד")]
        [Display(Name = "משכורת")]
        public float Salary { get; set; }

        [Display(Name = "תעריף בונוס")]
        public float BonusRate { get; set; }

        [Display(Name = "האם מועסק?")]
        public Boolean IsCurrentlyEmployed { get; set; }

        public enum Rank { Manager, StoreManager, ShiftManager, Employee, Trainee }

        public List<Order> Orders { get; set; }

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
