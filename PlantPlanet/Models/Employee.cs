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

        public int TeudatZehut { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // connects to Address id in Address class
        public int Address { get; set; }

        public DateTime StartDate { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "You must input Email")]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public float Salary { get; set; }

        public float BonusRate { get; set; }

        public Boolean IsCurrentlyEmployed { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public enum Rank { Manager, StoreManager, ShiftManager, Employee, Trainee }

        public enum AuthorizationLevel { Manager, StoreMAnager, Employee }

    }
}
