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

            // selecting all the subcategories that belong to a certain category
            var plantPlanetContext = _context.SubCategory.Include(s => s.ParentCategory).Where(a => a.ParentCategoryId.Equals(id)).OrderBy(a => a.Name);
            return View(await plantPlanetContext.ToListAsync());           
        }

        public async Task<IActionResult> Products(int? id)
        {
            // sending all subcategories to the index catalog view
            IList<Category> categoryList = new List<Category>();
            categoryList = _context.Category.ToArray();
            ViewData["categoriesList"] = categoryList;

            // sending all subcategories to the index catalog view
            IList<SubCategory> subCategoryList = new List<SubCategory>();
            subCategoryList = _context.SubCategory.ToArray();
            ViewData["subCategoriesList"] = subCategoryList;

            // selecting all the products that belong to a certain subcategory
            var productsByCategory = _context.Product.Include(p => p.Supplier).Include(p => p.SubCategories)
                .Where(p => p.SubCategories.Where(subCategory => subCategory.SubCategoryId.Equals(id)).Any());

            return View(await productsByCategory.ToListAsync());
        }
        public async Task<IActionResult> ProductPage(int? id)
        {
            // sending all subcategories to the index catalog view
            IList<Category> categoryList = new List<Category>();
            categoryList = _context.Category.ToArray();
            ViewData["categoriesList"] = categoryList;

            // sending all subcategories to the index catalog view
            IList<SubCategory> subCategoryList = new List<SubCategory>();
            subCategoryList = _context.SubCategory.ToArray();
            ViewData["subCategoriesList"] = subCategoryList;

            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Supplier)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        
        public async Task<IActionResult> Search(string query)
        {
            // sending all subcategories to the index catalog view
            IList<Category> categoryList = new List<Category>();
            categoryList = _context.Category.ToArray();
            ViewData["categoriesList"] = categoryList;

            // sending all subcategories to the index catalog view
            IList<SubCategory> subCategoryList = new List<SubCategory>();
            subCategoryList = _context.SubCategory.ToArray();
            ViewData["subCategoriesList"] = subCategoryList;

            var plantPlanetContext = _context.Product.Include(p => p.Supplier).Where(a => a.Name.Contains(query));
            return View("Products", await plantPlanetContext.ToListAsync());
        }

        public async Task<IActionResult> Filter(string NameQuery, string ColorQuery, int PriceQuery, int SaleQuery, string categoryQuery)
        {
            // sending all subcategories to the index catalog view
            IList<Category> categoryList = new List<Category>();
            categoryList = _context.Category.ToArray();
            ViewData["categoriesList"] = categoryList;

            // sending all subcategories to the index catalog view
            IList<SubCategory> subCategoryList = new List<SubCategory>();
            subCategoryList = _context.SubCategory.ToArray();
            ViewData["subCategoriesList"] = subCategoryList;

            var plantPlanetContext = _context.Product.Where(p => 
            (p.Name.Contains(NameQuery) || NameQuery == null) && 
            (p.SellingPrice <= PriceQuery || PriceQuery == 0) && 
            (p.Color.Contains(ColorQuery) || ColorQuery == null) && 
            ((p.Discount > 0 && SaleQuery == 1) || SaleQuery != 1) && 
            (p.SubCategories.Where(s => s.Name.Equals(categoryQuery)).Any()));

            return View("Products", await plantPlanetContext.ToListAsync());
        }
    }
}
