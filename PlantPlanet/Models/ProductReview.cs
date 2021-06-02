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

        public int ProductId { get; set; }

        [Required(ErrorMessage = "יש להזין מוצר")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "יש להזין דירוג")]
        public int Rating { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "יש להזין תאריך הזמנה")]
        public DateTime OrderTime { get; set; }

        public string Name { get; set; }

        public Boolean IsAnnonymous { get; set; }

        // add option to add pictures
    }
}
