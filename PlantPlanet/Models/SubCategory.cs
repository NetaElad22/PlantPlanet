using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [Required(ErrorMessage = "יש להזין שם תת קטגוריה")]
        [Display(Name = "שם תת קטגוריה")]
        public string Name { get; set; }

        [Display(Name = "תמונה")]
        public string ImageURL { get; set; }

        public int ParentCategoryId { get; set; }

        [Display(Name = "קטגוריית אם")]
        public Category ParentCategory { get; set; }

        public List<Product> Products { get; set; }
    }
}
