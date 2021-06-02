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
        public int TeudatZehut { get; set; }

        [Required(ErrorMessage = "יש להזין שם פרטי")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "יש להזין שם משפחה")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "יש להזין כתובת")]
        public Address Address { get; set; }

        [Required(ErrorMessage = "יש להזין תאריך העסקה")]
        public DateTime StartDate { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "יש להזין מייל")]
        public string Email { get; set; }

        [Required(ErrorMessage = "יש להזין מספר טלפון")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "יש להזין את משכורת העובד")]
        public float Salary { get; set; }

        public float BonusRate { get; set; }

        public Boolean IsCurrentlyEmployed { get; set; }

        [Required(ErrorMessage = "יש להזין שם משתמש למערכת")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "יש להזין סיסמא למערכת")]
        public string Password { get; set; }

        public enum Rank { Manager, StoreManager, ShiftManager, Employee, Trainee }

        public enum AuthorizationLevel { Manager, StoreMAnager, Employee }

        public List<Order> Orders { get; set; }
    }
}
