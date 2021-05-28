using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        public string Name { get; set; }

        public string ImageURL { get; set; } 

        public Category ParentCategory { get; set; }
    }
}
