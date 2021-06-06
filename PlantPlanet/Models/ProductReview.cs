﻿using System;
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
        [Display(Name = "שם המוצר")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "יש להזין דירוג")]
        [Display(Name = "דירוג המוצר")]
        public int Rating { get; set; }

        [Display(Name = "כותרת")]
        public string Title { get; set; }

        [Display(Name = "תוכן חוות הדעת")]
        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "יש להזין תאריך הזמנה")]
        [Display(Name = "תאריך ההזמנה")]
        public DateTime OrderTime { get; set; }

        [Display(Name = "שם הלקוח")]
        public string Name { get; set; }

        public Boolean IsAnnonymous { get; set; }

        // add option to add pictures
    }
}
