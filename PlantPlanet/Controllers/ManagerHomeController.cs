using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantPlanet.Data;
using PlantPlanet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class ManagerHomeController : Controller
    {
        private readonly PlantPlanetContext _context;

        public ManagerHomeController(PlantPlanetContext context )
        {
            _context = context;
           
        }

        public async Task<IActionResult> Index()
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
    }
}
