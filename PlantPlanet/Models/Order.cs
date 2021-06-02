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

        [Required(ErrorMessage = "You must input Products")]
        public List<OrderItem> Products { get; set; }

        public float OrderSumPayment { get; set; }

        [Required(ErrorMessage = "יש להזין כתובת למשלוח ההזמנה")]
        public Address ShippingAddress { get; set; }

        public string Message { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public string OrderComments { get; set; }

        public Boolean IsGift { get; set; }

        public string PaymentMethod { get; set; }

        public int PaymentsNumber { get; set; }

        public Boolean IsPremiumDiscount { get; set; }
        
        [Required(ErrorMessage = "יש להזין שיטת משלוח")]
        public DeliveryType DeliveryType { get; set; }

        public string PaymentVerification { get; set; }

        public const int MinSumForOrder = 100;

        public const int DeliveryFee = 15;

        public const int MinForNoDeliveryFee = 350;
    }
}
