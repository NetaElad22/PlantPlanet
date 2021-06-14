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

        public List<OrderItem> Products { get; set; }

        public float OrderSumPayment { get; set; }

        public string Message { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public string OrderComments { get; set; }

        public Boolean IsGift { get; set; }

        public string PaymentMethod { get; set; }

        public int PaymentsNumber { get; set; }

        public Boolean IsPremiumDiscount { get; set; }
        
        [Required(ErrorMessage = "יש להזין שיטת משלוח")]
        public int DeliveryTypeId { get; set; }

        public DeliveryType DeliveryType { get; set; }

        public string PaymentVerification { get; set; }

        public const int MinSumForOrder = 100;

        public const int DeliveryFee = 15;

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
