using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }

        [Display(Name = "שם חנות")]
        public string StoreName { get; set; }

        [Display(Name = "X")]
        public double StoreLocationX { get; set; }

        [Display(Name = "Y")]
        public double StoreLocationY { get; set; }
    }


}