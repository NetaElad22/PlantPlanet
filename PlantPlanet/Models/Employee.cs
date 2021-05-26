﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "You must input Permission")]
        public int Permission { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "You must input Email")]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public float Salary { get; set; }
        
        public Boolean IsCurrentlyEmployed { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Rank { get; set; }

    }
}
