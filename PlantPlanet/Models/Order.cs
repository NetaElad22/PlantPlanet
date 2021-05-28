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

        // connects to Customer id in Customer class
        [Required(ErrorMessage = "You must input Customer")]
        public int CustomerId { get; set; }

        //[Required(ErrorMessage = "You must input Products")]
        //public List<OrderItem> Products { get; set; }

        public float OrderSumPayment { get; set; }

        // connects to Address id in Address class
        public int ShippingAddress { get; set; }

        public string Message { get; set; }

        //connects to Employee id in Employee class
        public int EmployeeId { get; set; }

        public string OrderComments { get; set; }

        public Boolean IsGift { get; set; }

        public string PaymentMethod { get; set; }

        public int PaymentsNumber { get; set; }

        public Boolean IsPremiumDiscount { get; set; }

        // connects to DeliveryTpe id in DeliveryType class
        public  int DeliveryType { get; set; }

        public string PaymentVerification { get; set; }

        public const int MinSumForOrder = 100;

        public const int DeliveryFee = 15;

        public const int MinForNoDeliveryFee = 350;
    }
}
