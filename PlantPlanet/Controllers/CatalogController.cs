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
    public class CatalogController : Controller
    {
        private readonly PlantPlanetContext _context;

        public CatalogController(PlantPlanetContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // sending all subcategories to the index catalog view
            IList<SubCategory> subCategoryList = new List<SubCategory>();
            subCategoryList = _context.SubCategory.ToArray();
            ViewData["subCategoryList"] = subCategoryList;

            var plantPlanetContext = _context.Category.OrderBy(a => a.CategoryName);
            return View(await plantPlanetContext.ToListAsync());

        }

        public async Task<IActionResult> SubCategories(int? id)
        {
            // sending all categories to the index catalog view
            IList<Category> categoriesList = new List<Category>();
            categoriesList = _context.Category.ToArray();
            ViewData["categoriesList"] = categoriesList;

            var plantPlanetContext = _context.SubCategory.Include(s => s.ParentCategory).Where(a => a.ParentCategoryId.Equals(id)).OrderBy(a => a.Name);
            return View(await plantPlanetContext.ToListAsync());           
        }

        public async Task<IActionResult> Products(int? id)
        {
            var products = _context.Product.Include(p => p.Supplier);
            var list = new List<System.Linq.IQueryable<PlantPlanet.Models.Product>>();
            foreach(var product in products)
            {
                if (product.SubCategories != null)
                {
                    foreach (var subcategory in product.SubCategories)
                    {
                        if (subcategory.SubCategoryId == id)
                        {
                            var insert = _context.Product.Include(p => p.Supplier).Where(a => a.ProductId == product.ProductId).OrderBy(a => a.Name);
                            list.Add(insert);
                        }
                    }
                } else {
                    return NotFound();
                }
            }
            return View(await products.ToListAsync());
        }

        public async Task<IActionResult> Search(string query)
        {
            var plantPlanetContext = _context.Product.Include(p => p.Supplier).Where(a => a.Name.Contains(query));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

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
    }
}
