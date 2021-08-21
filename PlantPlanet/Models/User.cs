using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public enum AuthorizationLevel { Manager, StoreManager, Employee, Customer }

    public class User
    {
        [Key]
        [Required(ErrorMessage = "יש להזין שם משתמש")]
        [Display(Name = "שם משתמש")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "יש להזין סיסמא")]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמא")]
        public string Password { get; set; }

        public string Type { get; set; } = "Manager";

    }
}