using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class ProductReview
    {
        public int ProductReviewId { get; set; }

        [Required(ErrorMessage = "יש להזין מוצר")]
        [Display(Name = "מוצר")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required(ErrorMessage = "יש להזין דירוג")]
        [Display(Name = "דירוג")]
        public int Rating { get; set; }

        [Display(Name = "כותרת")]
        public string Title { get; set; }

        [Display(Name = "תוכן")]
        public string Content { get; set; }

        [Display(Name = "תאריך")]
        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "יש להזין תאריך הזמנה")]
        [Display(Name = "תאריך קניית המוצר")]
        public DateTime OrderTime { get; set; }

        [Display(Name = "שם")]
        public string Name { get; set; }

        [Display(Name = "האם אנונימי?")]
        public Boolean IsAnnonymous { get; set; }

        // add option to add pictures
    }
}
