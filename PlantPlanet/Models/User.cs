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
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public AuthorizationLevel Type { get; set; }

    }
}