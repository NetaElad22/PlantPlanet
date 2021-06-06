using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required(ErrorMessage = "יש להזין מוצרים להזמנה")]
        [Display(Name = "מוצרים")]
        public List<OrderItem> Products { get; set; }

        public float OrderSumPayment { get; set; }

        [Required(ErrorMessage = "יש להזין כתובת למשלוח ההזמנה")]
        public Address ShippingAddress { get; set; }

        [Display(Name = "ברכה על החבילה")]
        public string Message { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [Display(Name = "הערה להזמנה")]
        public string OrderComments { get; set; }

        public Boolean IsGift { get; set; }

        [Display(Name = "שיטת תשלום")]
        public string PaymentMethod { get; set; }

        [Display(Name = "מספר תשלומים")]
        public int PaymentsNumber { get; set; }

        public Boolean IsPremiumDiscount { get; set; }

        [Required(ErrorMessage = "יש להזין שיטת משלוח")]
        [Display(Name = "שיטת משלוח")]
        public DeliveryType DeliveryType { get; set; }

        [Display(Name = "אישור תשלום")]
        public string PaymentVerification { get; set; }

        public const int MinSumForOrder = 100;

        public const int DeliveryFee = 15;

        public const int MinForNoDeliveryFee = 350;

        public enum OrderStatus { WaitingForAssemling, InTheMaking, WaitingForDelivery,InDelivery}
    }
}
