using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "יש להזין את שם המוצר")]
        [Display(Name = "שם המוצר")]
        public string Name { get; set; }

        [Display(Name = "תיאור")]
        public string Description { get; set; }

        [Display(Name = "טיפול")]
        public string Treatment { get; set; }

        [Display(Name = "טיפים לטיפול")]
        public string TreatmentTips { get; set; }

        [Display(Name = "קטגוריה")]
        public List<SubCategory> SubCategories { get; set; }

        //[Required(ErrorMessage = "יש לשייך את המוצר לקטגוריה")]
        //public Category Category { get; set; }
        
        [Required(ErrorMessage = "יש להזין את מחיר עלות המוצר")]
        [Display(Name = "מחיר עלות")]
        public float BuyingCost { get; set; }

        [Required(ErrorMessage = "יש להזין את מחיר מכירת המוצר")]
        [Display(Name = "מחיר מכירה")]
        public float SellingPrice { get; set; }

        public int SupplierId { get; set; }

        [Display(Name = "ספק")]
        public Supplier Supplier { get; set; }

        [Display(Name = "אחוזי הנחה")]
        public float Discount { get; set; }

        [Display(Name = "צבע")]
        public string Color { get; set; }

        [Display(Name = "גודל בסנטימטר")]
        public int Size { get; set; }

        [Display(Name = "כמות במלאי")]
        public int Quantity { get; set; }

        [Display(Name = "חוות דעת על המוצר")]
        public List<ProductReview> ProductReviews { get; set; }

        [Display(Name = "תמונה")]
        public string ImageURL { get; set; }

        [Display(Name = "רווח נקי")]
        public float NetIncome { get; set; }

        [Display(Name = "כמות שנמכרה")]
        public int UnitsSold { get; set; }

    }
}
