using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlantPlanet.Data;
using PlantPlanet.Models;

namespace PlantPlanet.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly PlantPlanetContext _context;
        private readonly IHostingEnvironment _hosting;
        public const string DefaultPictureURL = "DefaultPicture.jpg";

        public CategoriesController(PlantPlanetContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Category.ToListAsync());
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile ImageURL, [Bind("CategoryId,CategoryName,ImageURL")] Category category)
        {
            if (ModelState.IsValid)
            {
                if(ImageURL == null)
                {
                    category.ImageURL = DefaultPictureURL;
                    _context.Add(category);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var filename = Path.Combine(_hosting.WebRootPath, Path.GetFileName(ImageURL.FileName));
                    category.ImageURL = ImageURL.FileName;
                    _context.Add(category);
                    ImageURL.CopyTo(new FileStream(filename, FileMode.Create));
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile ImageURL, [Bind("CategoryId,CategoryName,ImageURL")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }            
            if (ModelState.IsValid)
            {
                try
                {
                    if (ImageURL == null)
                    {
                        category.ImageURL = _context.Category.Where(c => c.CategoryId == id).AsNoTracking().First().ImageURL;
                    }
                    else
                    {
                        var filename = Path.Combine(_hosting.WebRootPath, Path.GetFileName(ImageURL.FileName));
                        category.ImageURL = ImageURL.FileName;
                        ImageURL.CopyTo(new FileStream(filename, FileMode.Create));
                    }
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
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
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Category.FindAsync(id);
            _context.Category.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.CategoryId == id);
        }
    }
}
