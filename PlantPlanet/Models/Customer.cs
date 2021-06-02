﻿using System;
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

        [Required(ErrorMessage = "יש להזין כתובת")]
        [Display(Name = "כתובת")]
        public Address Address { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "יש להזין מייל")]
        [Display(Name = "מייל")]
        public string Email { get; set; }

        [Required(ErrorMessage = "יש להזין מספר טלפון")]
        [Display(Name = "מספר טלפון")]
        public int PhoneNumber { get; set; }

        public Boolean IsPremium { get; set; }

    }
}
