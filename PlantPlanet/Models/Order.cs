using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must input Customer")]
        public Customer CustomerId { get; set; }

        [Required(ErrorMessage = "You must input Products")]
        public List<Product> Products { get; set; }

        public float OrderSumPayment { get; set; }

        public Address ShippingAddress { get; set; }

        public string Message { get; set; }

        public Employee Employee { get; set; }

        public string OrderComments { get; set; }

        public Boolean IsGift { get; set; }

        public string PaymentMethod { get; set; }

        public int PaymentsNumber { get; set; }

        public Boolean IsPremiumDiscount { get; set; }

        public  DeliveryType DeliveryType { get; set; }

        public const int MinSumForOrder = 100;

        public const int DeliveryFee = 15;

        public const int MinForNoDeliveryFee = 350;
    }
}
