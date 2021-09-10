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
    public class DeliveryTypesController : Controller
    {
        private readonly PlantPlanetContext _context;

        public DeliveryTypesController(PlantPlanetContext context)
        {
            _context = context;
        }

        // GET: DeliveryTypes
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeliveryType.ToListAsync());
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Search(string query)
        {
            var plantPlanetContext = _context.DeliveryType.Where(a => a.Type.Contains(query));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Filter(string nameQuery, int additionQuery, int idQuery)
        {
            var plantPlanetContext = _context.DeliveryType.Where(a => (a.Type.Contains(nameQuery) || nameQuery == null) &&
            (a.DeliveryCostAddition <= additionQuery || additionQuery == 0) &&
            (a.DeliveryTypeId == idQuery || idQuery == 0));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

        // GET: DeliveryTypes/Details/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryType = await _context.DeliveryType
                .FirstOrDefaultAsync(m => m.DeliveryTypeId == id);
            if (deliveryType == null)
            {
                return NotFound();
            }

            return View(deliveryType);
        }

        // GET: DeliveryTypes/Create
        [Authorize(Roles = "Manager")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeliveryTypeId,Type,DeliveryCostAddition")] DeliveryType deliveryType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryType);
        }

        // GET: DeliveryTypes/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryType = await _context.DeliveryType.FindAsync(id);
            if (deliveryType == null)
            {
                return NotFound();
            }
            return View(deliveryType);
        }

        // POST: DeliveryTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Manager")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeliveryTypeId,Type,DeliveryCostAddition")] DeliveryType deliveryType)
        {
            if (id != deliveryType.DeliveryTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryTypeExists(deliveryType.DeliveryTypeId))
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
            return View(deliveryType);
        }

        // GET: DeliveryTypes/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryType = await _context.DeliveryType
                .FirstOrDefaultAsync(m => m.DeliveryTypeId == id);
            if (deliveryType == null)
            {
                return NotFound();
            }

            return View(deliveryType);
        }

        // POST: DeliveryTypes/Delete/5
        [Authorize(Roles = "Manager")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryType = await _context.DeliveryType.FindAsync(id);
            _context.DeliveryType.Remove(deliveryType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Manager")]
        private bool DeliveryTypeExists(int id)
        {
            return _context.DeliveryType.Any(e => e.DeliveryTypeId == id);
        }
    }
}
