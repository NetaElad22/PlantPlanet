using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantPlanet.Models;
using PlantPlanet.Data;
using Microsoft.AspNetCore.Http;


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

            cart.Add(new CartProduct(product, quantity));
            ViewData["cart"] = cart;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            return View("index");
        }
    }
}
