using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlantPlanet.Data;
using PlantPlanet.Models;

namespace PlantPlanet.Controllers
{
    public class PremuimsController : Controller
    {
        private readonly PlantPlanetContext _context;

        public PremuimsController(PlantPlanetContext context)
        {
            _context = context;
        }

        // GET: Premuims
        public async Task<IActionResult> Index()
        {
            return View(await _context.Premuim.ToListAsync());
        }

        // GET: Premuims/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premuim = await _context.Premuim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (premuim == null)
            {
                return NotFound();
            }

            return View(premuim);
        }

        // GET: Premuims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Premuims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,ExpirationDate,Customer")] Premuim premuim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(premuim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(premuim);
        }

        // GET: Premuims/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premuim = await _context.Premuim.FindAsync(id);
            if (premuim == null)
            {
                return NotFound();
            }
            return View(premuim);
        }

        // POST: Premuims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,ExpirationDate,Customer")] Premuim premuim)
        {
            if (id != premuim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(premuim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PremuimExists(premuim.Id))
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
            return View(premuim);
        }

        // GET: Premuims/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premuim = await _context.Premuim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (premuim == null)
            {
                return NotFound();
            }

            return View(premuim);
        }

        // POST: Premuims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var premuim = await _context.Premuim.FindAsync(id);
            _context.Premuim.Remove(premuim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PremuimExists(int id)
        {
            return _context.Premuim.Any(e => e.Id == id);
        }
    }
}
