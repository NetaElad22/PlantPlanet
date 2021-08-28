using Microsoft.AspNetCore.Mvc;
using PlantPlanet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly PlantPlanetContext _context;

        public UserInfoController(PlantPlanetContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var customer = _context.Customer.Where((customer) => customer.User.UserName == userName).FirstOrDefault();
            var customerOrders = _context.Order.Where((order) => order.CustomerId == customer.CustomerId).ToList();
            ViewData["customer"] = customer;
            ViewData["customerOrders"] = customerOrders;

            return View();
        }

        public IActionResult Edit()
        {
            var userName = User.Identity.Name;
            var customer = _context.Customer.Where((customer) => customer.User.UserName == userName).FirstOrDefault();
            ViewData["customer"] = customer;

            return View();
        }
    }
}
