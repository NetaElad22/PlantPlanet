using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "יש להזין שם קטגוריה")]
        [Display(Name = "שם קטגוריה")]
        public string CategoryName { get; set; }

        [Display(Name = "תמונה")]
        public string ImageURL { get; set; }

        [Display(Name = "תתי קטגוריות")]
        public List<SubCategory> SubCategories { get; set; }
    }
}
