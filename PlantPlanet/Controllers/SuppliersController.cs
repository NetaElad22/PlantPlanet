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
    public class SuppliersController : Controller
    {
        private readonly PlantPlanetContext _context;

        public SuppliersController(PlantPlanetContext context)
        {
            _context = context;
        }

        // GET: Suppliers
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Index()
        {
            // sending all products to the suppliers view
            IList<Product> productList = new List<Product>();
            productList = _context.Product.Include(p => p.Supplier).ToArray();
            ViewData["productList"] = productList;

            return View(await _context.Supplier.ToListAsync());
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Search(string query)
        {
            var plantPlanetContext = _context.Supplier.Where(a => a.CompanyName.Contains(query));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Filter(string nameQuery, string emailQuery, string phoneQuery, string productQuery)
        {
            // sending all products to the suppliers view
            IList<Product> productList = new List<Product>();
            productList = _context.Product.Include(p => p.Supplier).ToArray();
            ViewData["productList"] = productList;

            var plantPlanetContext = _context.Supplier.Where(a => a.CompanyName.Contains(nameQuery) || (nameQuery == null) &&
            (a.SuppliedProducts.Where(p => p.Name.Equals(productQuery)).Any() || productQuery.Equals("הכל")) &&
            (a.Email.Contains(emailQuery) || emailQuery == null) &&
            (a.PhoneNumber.Contains(phoneQuery) || phoneQuery == null));

            return View("Index", await plantPlanetContext.ToListAsync());
        }

        // GET: Suppliers/Details/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var supplier = await _context.Supplier.Include(s => s.SuppliedProducts)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
           
            if (supplier == null)
            {
                return NotFound();
            }

            IList<Product> ProductList = new List<Product>();
            ProductList = _context.Product.Where(p => p.SupplierId == id).ToArray();
            ViewData["ProductList"] = ProductList;

            return View(supplier);
        }

        // GET: Suppliers/Create
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,CompanyName,PhoneNumber,Email")] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        // GET: Suppliers/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return View(supplier);
        }

        // POST: Suppliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,CompanyName,PhoneNumber,Email")] Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierExists(supplier.SupplierId))
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
            return View(supplier);
        }

        // GET: Suppliers/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplier = await _context.Supplier
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplier == null)
            {
                return NotFound();
            }

            return View(supplier);
        }

        // POST: Suppliers/Delete/5
        [Authorize(Roles = "Manager")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplier = await _context.Supplier.FindAsync(id);
            _context.Supplier.Remove(supplier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierExists(int id)
        {
            return _context.Supplier.Any(e => e.SupplierId == id);
        }
    }
}
