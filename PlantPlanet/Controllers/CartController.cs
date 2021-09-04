using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantPlanet.Models;
using PlantPlanet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PlantPlanet.Controllers
{
    public class CartController : Controller
    {
        private readonly PlantPlanetContext _context;

        public CartController(PlantPlanetContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AddToCart(int id, int quantity)
        {
            //HttpContext.Session.SetObject("sbyte");

            Product product = _context.Product.Where(p => p.ProductId == id).First();
            List<CartProduct> cart = new List<CartProduct>();

            if (SessionHelper.GetObjectFromJson<List<CartProduct>>(HttpContext.Session, "cart") != null)
            {
                cart = SessionHelper.GetObjectFromJson<List<CartProduct>>(HttpContext.Session, "cart");
            }


            // if this item is already in the cart - increase the quantity instead of adding it

            if (cart.Exists((cartProduct) => cartProduct.product.ProductId == product.ProductId))
            {
                cart.ForEach(cartItem =>
                {
                    if (cartItem.product.ProductId == product.ProductId)
                    {
                        cartItem.quantity += quantity;
                    }
                });
            }
            else
            {
                cart.Add(new CartProduct(product, quantity));
            }

            ViewData["cart"] = cart;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return RedirectToAction("Index", "Cart");
        }

        public async Task<IActionResult> RemoveProduct(int id)
        {

            if (SessionHelper.GetObjectFromJson<List<CartProduct>>(HttpContext.Session, "cart") != null)
            {
                Product product = _context.Product.Where(p => p.ProductId == id).First();

                List<CartProduct> cart = SessionHelper.GetObjectFromJson<List<CartProduct>>(HttpContext.Session, "cart");
                CartProduct productToRemove = cart.Find((cartProduct) => cartProduct.product.ProductId == product.ProductId);
                cart.Remove(productToRemove);

                ViewData["cart"] = cart;
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index", "Cart");
        }

        public async Task<IActionResult> Order(float sum)
        {
            ViewBag.DeliveryTypeId = new SelectList(_context.DeliveryType, "DeliveryTypeId", "Type");
            ViewData["sum"] = sum;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Order([Bind("PaymentMethod,PaymentsNumber,PaymentVerification,DeliveryTypeId,City,Street,HouseNumber,FloorNumber,FlatNumber,ZipCode,Message,OrderComments,IsPremiumDiscount,IsGift")] Order order)
        {
            if (ModelState.IsValid && User.Identity.Name != null)
            {
                List<CartProduct> cartItems = SessionHelper.GetObjectFromJson<List<CartProduct>>(HttpContext.Session, "cart");
                List<OrderItem> orderItems = new List<OrderItem>();
                cartItems.ForEach(cartItem => {
                    OrderItem orderItem = new OrderItem();
                    /*orderItem.Product.Quantity = cartItem.quantity;*/
                    orderItem.ProductId = cartItem.product.ProductId;
                    orderItems.Add(orderItem);
                });
                order.Products = orderItems;
                order.OrderSumPayment = 0;
                order.CustomerId = _context.Customer.Where((customer) => customer.User.UserName == User.Identity.Name).First().CustomerId;
                order.EmployeeId = _context.Employee.First().EmployeeId;
                _context.Add(order);
                await _context.SaveChangesAsync();
                ViewData["cart"] = null;
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", null);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
    }
}
