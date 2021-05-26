using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class ProductReview
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Rating { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime PublicationDate { get; set; }
    }
}
