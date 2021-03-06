using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public enum AuthorizationLevel { Manager, Employee, Customer }

    public class User
    {
        //public User(string userName, string password)
        //{
        //    UserName = userName;
        //    Password = password;
        //    Type = "Customer";
        //}

        [Key]
        [Required(ErrorMessage = "יש להזין שם משתמש")]
        [Display(Name = "שם משתמש")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "יש להזין סיסמא")]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמא")]
        public string Password { get; set; }

        [Display(Name = "סוג משתמש")]
        public string Type { get; set; } = "Customer";

        //public int CustomerId { get; set; }

        //public Customer Customer { get; set; }


    }
}