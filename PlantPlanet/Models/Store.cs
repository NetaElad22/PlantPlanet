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
        public float StoreLocationX { get; set; }

        [Display(Name = "Y")]
        public float StoreLocationY { get; set; }
    }


}

//namespace PlantPlanet
//{
//   public struct Location
//    {
//        public decimal x;
//        public decimal y;
    
//    }
//}