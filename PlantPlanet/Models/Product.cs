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

        public string Description { get; set; }

        public string Treatment { get; set; }

        public string TreatmentTips { get; set; }

        public List<SubCategory> SubCategories { get; set; }

        [Required(ErrorMessage = "יש לשייך את המוצר לקטגוריה")]
        public Category Category { get; set; }

        [Required(ErrorMessage = "יש להזין את מחיר עלות המוצר")]
        public float BuyingCost { get; set; }

        [Required(ErrorMessage = "יש להזין את מחיר מכירת המוצר")]
        public float SellingPrice { get; set; }

        public int SupplierId { get; set; }

        [Required(ErrorMessage = "יש להזין את ספק המוצר")]
        public Supplier Supplier { get; set; }

        public float Discount { get; set; }

        [Required(ErrorMessage = "יש להזין את צבע המוצר")]
        public string Color { get; set; }

        [Required(ErrorMessage = "יש להזין את גודל המוצר")]
        public int Size { get; set; }

        public int StockId { get; set; }

        [Required(ErrorMessage = "יש להזין את כמות היחידות במלאי")]
        public Stock AvailableStock { get; set; }

        public List<ProductReview> ProductReviews { get; set; }

        public string ImageURL { get; set; }

        public float NetIncome { get; set; }

        public int UnitsSold { get; set; }

    }
}
