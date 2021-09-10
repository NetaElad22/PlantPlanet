using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlantPlanet.Data;
using PlantPlanet.Models;

namespace PlantPlanet.Controllers
{
    public class CustomersController : Controller
    {
        private readonly PlantPlanetContext _context;

        public CustomersController(PlantPlanetContext context)
        {
            _context = context;
        }

        // GET: Customers
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Search(string query)
        {
            var plantPlanetContext = _context.Customer.Where(a => (a.FirstName.Contains(query) || a.LastName.Contains(query)));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Filter(string NameQuery, string phoneQuery, string cityQuery)
        {
            var plantPlanetContext = _context.Customer.Where(a => (a.FirstName.Contains(NameQuery) || a.LastName.Contains(NameQuery) || NameQuery == null) &&
            (a.PhoneNumber.Contains(phoneQuery) || phoneQuery == null) &&
            (a.City.Contains(cityQuery) || cityQuery == null));

            return View("Index", await plantPlanetContext.ToListAsync());
        }

        // GET: Customers/Details/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,Email,PhoneNumber,User,IsPremium,City,Street,HouseNumber,FloorNumber,FlatNumber,ZipCode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                var q = from u in _context.User
                        where u.UserName == customer.User.UserName
                        select u;
                if (q.Count() == 0) { 
                    _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
                }
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [Authorize(Roles = "Manager")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Manager")]
        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }
    }
}
