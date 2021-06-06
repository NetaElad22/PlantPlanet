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

        [Required(ErrorMessage = "יש להזין כתובת")]
        [Display(Name = "כתובת")]
        public Address Address { get; set; }

        [Required(ErrorMessage = "יש להזין תאריך העסקה")]
        [Display(Name = "תאריך העסקה")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "יש להזין מייל")]
        [Display(Name = "מייל")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "יש להזין מספר טלפון")]
        [Display(Name = "מספר טלפון נייד")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "יש להזין את משכורת העובד")]
        [Display(Name = "משכורת")]
        public float Salary { get; set; }

        [Display(Name = "בונוס")]
        public float BonusRate { get; set; }

        public Boolean IsCurrentlyEmployed { get; set; }

        public enum Rank { Manager, StoreManager, ShiftManager, Employee, Trainee }

        [Display(Name = "רשימת הזמנות")]
        public List<Order> Orders { get; set; }
    }
}
