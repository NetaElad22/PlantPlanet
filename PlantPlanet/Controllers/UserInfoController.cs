using Microsoft.AspNetCore.Mvc;
using PlantPlanet.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantPlanet.Models;
using Microsoft.EntityFrameworkCore;

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
            var customer = _context.Customer.Where((customer) => customer.User.UserName == userName).Include(u => u.User).FirstOrDefault();
            var customerOrders = _context.Order.Where(order => order.CustomerId == customer.CustomerId).ToList();
            ViewData["customer"] = customer;
            ViewData["customerOrders"] = customerOrders;

            return View();
        }

        public IActionResult Edit()
        {
            var userName = User.Identity.Name;
            var customer = _context.Customer.Where((customer) => customer.User.UserName == userName).Include(u => u.User).FirstOrDefault();
            ViewData["customer"] = customer;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,Email,PhoneNumber,IsPremium,City,Street,HouseNumber,FloorNumber,FlatNumber,ZipCode")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Edit", "UserInfo");
            }
            return RedirectToAction(nameof(Index));
        }
        
        public IActionResult Order(int id)
        {
            var order = _context.Order.Where((order) => order.OrderId == id).Include(o => o.Products).ThenInclude(o => o.Product).First();
            ViewData["order"] = order;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(string prevPassword, string currPassword)
        {
            var userName = User.Identity.Name;
            var userData = _context.User.Where((user) => user.UserName == userName).First();
            if (prevPassword == userData.Password)
            {
                // change password
                userData.Password = currPassword;
                _context.Update(userData);
                await _context.SaveChangesAsync();
                TempData["error"] = "";
                return RedirectToAction("Logout", "Users");
            } else
            {
                TempData["error"] = "הסיסמא הנוכחית שגויה";
                return RedirectToAction("Edit", "UserInfo");
            }
        }
        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }

    }
}
