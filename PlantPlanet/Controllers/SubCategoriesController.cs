using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlantPlanet.Data;
using PlantPlanet.Models;
using Microsoft.AspNetCore.Http;

namespace PlantPlanet.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly PlantPlanetContext _context;
        private readonly IHostingEnvironment _hosting;
        public const string DefaultPictureURL = "DefaultPicture.jpg";

        public SubCategoriesController(PlantPlanetContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        // GET: SubCategories
        public async Task<IActionResult> Index()
        {
            var plantPlanetContext = _context.SubCategory.Include(s => s.ParentCategory);
            return View(await plantPlanetContext.ToListAsync());
        }

        public async Task<IActionResult> Search(string query)
        {
            var plantPlanetContext = _context.SubCategory.Where(a => a.Name.Contains(query));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

        // GET: SubCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _context.SubCategory
                .Include(s => s.ParentCategory)
                .FirstOrDefaultAsync(m => m.SubCategoryId == id);
            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);
        }

        // GET: SubCategories/Create
        public IActionResult Create()
        {
            ViewData["ParentCategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName");
            return View();
        }

        // POST: SubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile ImageURL, [Bind("SubCategoryId,Name,ImageURL,ParentCategoryId")] SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                if (ImageURL == null)
                {
                    subCategory.ImageURL = DefaultPictureURL;
                    _context.Add(subCategory);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                } 
                else
                {
                    var filename = Path.Combine(_hosting.WebRootPath, Path.GetFileName(ImageURL.FileName));
                    subCategory.ImageURL = ImageURL.FileName;
                    _context.Add(subCategory);
                    ImageURL.CopyTo(new FileStream(filename, FileMode.Create));
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["ParentCategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", subCategory.ParentCategoryId);
            return View(subCategory);
        }

        // GET: SubCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _context.SubCategory.FindAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }
            ViewData["ParentCategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", subCategory.ParentCategoryId);
            return View(subCategory);
        }

        // POST: SubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile ImageURL, [Bind("SubCategoryId,Name,ImageURL,ParentCategoryId")] SubCategory subCategory)
        {
            if (id != subCategory.SubCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ImageURL == null)
                    {
                        subCategory.ImageURL = _context.SubCategory.Where(c => c.SubCategoryId == id).AsNoTracking().First().ImageURL;
                    }
                    else
                    {
                        var filename = Path.Combine(_hosting.WebRootPath, Path.GetFileName(ImageURL.FileName));
                        subCategory.ImageURL = ImageURL.FileName;
                        ImageURL.CopyTo(new FileStream(filename, FileMode.Create));
                    }
                    _context.Update(subCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCategoryExists(subCategory.SubCategoryId))
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
            ViewData["ParentCategoryId"] = new SelectList(_context.Category, "CategoryId", "CategoryName", subCategory.ParentCategoryId);
            return View(subCategory);
        }

        // GET: SubCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subCategory = await _context.SubCategory
                .Include(s => s.ParentCategory)
                .FirstOrDefaultAsync(m => m.SubCategoryId == id);
            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);
        }

        // POST: SubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subCategory = await _context.SubCategory.FindAsync(id);
            _context.SubCategory.Remove(subCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubCategoryExists(int id)
        {
            return _context.SubCategory.Any(e => e.SubCategoryId == id);
        }
    }
}
