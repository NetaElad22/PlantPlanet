using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlantPlanet.Data;
using PlantPlanet.Models;

namespace PlantPlanet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PlantPlanetContext _context;


        public HomeController(ILogger<HomeController> logger, PlantPlanetContext context)
        {
            _logger = logger;
            _context = context;
        }

        //[Authorize]
        public IActionResult Index()
        {
            var isAuth = HttpContext.User.IsInRole("Customer");
            isAuth = HttpContext.User.IsInRole("Manager");

            return View();
        }

        public async Task<IActionResult> ManagerHome()
        {

            List<Quantity> availableQuantity = new List<Quantity>();
            string titles = "";

            var plantPlanetContext = _context.Product.Include(p => p.Supplier);
            var productsList = await plantPlanetContext.ToListAsync();
            foreach (var item in productsList)
            {
                availableQuantity.Add(new Quantity(item.ProductId, item.Quantity));
                titles += item.ProductId + ",";
            }
            ViewData["availableQuantity"] = availableQuantity;
            ViewBag.titles = titles;


            var orderItemList = await _context.OrderItem.ToListAsync();
            List<Quantity> productsSold = new List<Quantity>();

            foreach (var orderItem in orderItemList)
            {
                bool isProductExist = false;
                productsSold.ForEach(ps => {
                    if (ps.id == orderItem.ProductId)
                    {
                        ps.quantity += orderItem.Quantity;
                        isProductExist = true;
                    }
                });
                if (!isProductExist)
                {
                    productsSold.Add(new Quantity(orderItem.ProductId, orderItem.Quantity));
                }
            }
            ViewData["productsSold"] = productsSold;

            return View(productsList);
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CommonQuestions()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}