using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Order
    {
        [Display(Name = "מספר הזמנה")]
        public int OrderId { get; set; }

        [Display(Name = "לקוח")]
        public int CustomerId { get; set; }

        [Display(Name = "לקוח")]
        public Customer Customer { get; set; }

        [Display(Name = "מוצרים")]
        public List<OrderItem> Products { get; set; }

        [Display(Name = "סכום הזמנה")]
        public float OrderSumPayment { get; set; }

        [Display(Name = "הודעה")]
        public string Message { get; set; }

        [Display(Name = "מספר עובד אחראי")]
        public int EmployeeId { get; set; }

        [Display(Name = "עובד אחראי")]
        public Employee Employee { get; set; }

        [Display(Name = "הערות להזמנה")]
        public string OrderComments { get; set; }

        [Display(Name = "האם מתנה")]
        public Boolean IsGift { get; set; }

        [Display(Name = "סוג תשלום")]
        public string PaymentMethod { get; set; }

        [Display(Name = "מספר תשלומים")]
        public int PaymentsNumber { get; set; }

        [Display(Name = "האם חבר מועדון")]
        public Boolean IsPremiumDiscount { get; set; }

        [Display(Name = "סוג משלוח")]
        [Required(ErrorMessage = "יש להזין שיטת משלוח")]
        public int DeliveryTypeId { get; set; }

        [Display(Name = "סוג משלוח")]
        public DeliveryType DeliveryType { get; set; }

        [Display(Name = "מספר אישור תשלום")]
        public string PaymentVerification { get; set; }

        [Display(Name = "מינימום הזמנה")]
        public const int MinSumForOrder = 100;

        [Display(Name = "מחיר משלוח")]
        public const int DeliveryFee = 15;

        [Display(Name = "מינימום הזמנה למשלוח")]
        public const int MinForNoDeliveryFee = 350;

        [Required(ErrorMessage = "יש להזין עיר")]
        [Display(Name = "עיר")]
        public string City { get; set; }

        [Required(ErrorMessage = "יש להזין רחוב")]
        [Display(Name = "רחוב")]
        public string Street { get; set; }

        [Required(ErrorMessage = "יש להזין מספר בית")]
        [Display(Name = "מספר בית")]
        public string HouseNumber { get; set; }

        [Display(Name = "קומה")]
        public string FloorNumber { get; set; }

        [Display(Name = "מספר דירה")]
        public string FlatNumber { get; set; }

        [Required(ErrorMessage = "יש להזין מיקוד")]
        [Display(Name = "מיקוד")]
        public string ZipCode { get; set; }
    }
}
