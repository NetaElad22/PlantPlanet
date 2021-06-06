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
        public string Name { get; set; }

        [Display(Name = "תיאור המוצר")]
        public string Description { get; set; }

        [Display(Name = "איך מטפלים?")]
        public string Treatment { get; set; }

        [Display(Name = "טיפים חשובים")]
        public string TreatmentTips { get; set; }

        [Display(Name = "תת קטגוריה")]
        public SubCategory SubCategory { get; set; }

        [Required(ErrorMessage = "יש לשייך את המוצר לקטגוריה")]
        [Display(Name = "קטגוריה")]
        public Category Category { get; set; }

        [Required(ErrorMessage = "יש להזין את מחיר עלות המוצר")]
        [Display(Name = "מחיר עלות המוצר")]
        public float BuyingCost { get; set; }

        [Required(ErrorMessage = "יש להזין את מחיר מכירת המוצר")]
        [Display(Name = "מחיר מכירת המוצר")]
        public float SellingPrice { get; set; }

        public int SupplierId { get; set; }

        [Required(ErrorMessage = "יש להזין את ספק המוצר")]
        [Display(Name = "ספק המוצר")]
        public Supplier Supplier { get; set; }

        [Display(Name = "אחוזי הנחה")]
        public float Discount { get; set; }

        [Required(ErrorMessage = "יש להזין את צבע המוצר")]
        [Display(Name = "צבע המוצר")]
        public string Color { get; set; }

        [Required(ErrorMessage = "יש להזין את גודל המוצר")]
        [Display(Name = "גודל המוצר")]
        public int Size { get; set; }

        public int StockId { get; set; }

        [Required(ErrorMessage = "יש להזין את כמות היחידות במלאי")]
        [Display(Name = "מלאי המוצר")]
        public Stock AvailableStock { get; set; }

        [Display(Name = "חוות דעת על המוצר")]
        public List<ProductReview> ProductReviews { get; set; }

        [Display(Name = "תמונה")]
        public string ImageURL { get; set; }

        [Display(Name = "רווח כולל מהמוצר")]
        public float NetIncome { get; set; }

        [Display(Name = "כמות יחידות שנמכרו")]
        public int UnitsSold { get; set; }

    }
}
