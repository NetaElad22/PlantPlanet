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
        public string Name { get; set; }

        public string ImageURL { get; set; }

        public int ParentCategoryId { get; set; }

        [Required(ErrorMessage = "יש להזין קטגוריה")]
        public Category ParentCategory { get; set; }
    }
}
