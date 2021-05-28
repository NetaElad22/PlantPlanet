using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class ProductReview
    {
        public int ProductReviewId { get; set; }

        public int ProductId { get; set; }

        public int Rating { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublicationDate { get; set; }

        public DateTime OrderTime { get; set; }

        public string Name { get; set; }

        public Boolean IsAnnonymous { get; set; }

        // add option to add pictures
    }
}
