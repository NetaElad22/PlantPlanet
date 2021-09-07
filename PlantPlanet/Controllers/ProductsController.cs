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
using System.Text.Json;

namespace PlantPlanet.Controllers
{
    public class ProductsController : Controller
    {
        private readonly PlantPlanetContext _context;
        private readonly IHostingEnvironment _hosting;
        public const string DefaultPictureURL = "DefaultPicture.jpg";

        public ProductsController(PlantPlanetContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }



        // GET: Products
        public async Task<IActionResult> Index()
        {
            List<Quantity> availableQuantity = new List<Quantity>();
            string titles = "";

            var plantPlanetContext = _context.Product.Include(p => p.Supplier);
            var productsList = await plantPlanetContext.ToListAsync();
            foreach(var item in productsList){
                availableQuantity.Add(new Quantity(item.ProductId, item.Quantity));
                titles += item.ProductId+",";
            }
            ViewData["availableQuantity"] = availableQuantity;
            ViewBag.titles = titles;


            //var oiList =  _context.OrderItem.Include(oi => oi.ProductId);
            var orderItemList = await _context.OrderItem.ToListAsync();
            List<Quantity> productsSold = new List<Quantity>();

            foreach (var orderItem in orderItemList)
            {
                bool isProductExist = false;
                productsSold.ForEach(ps => {
                    if (ps.id == orderItem.ProductId)
                    {
                        ps.quantity += orderItem.Quantity;
                        isProductExist = true;
                    }
                });
                if (!isProductExist)
                {
                    productsSold.Add(new Quantity(orderItem.ProductId, orderItem.Quantity));
                }
            }
            ViewData["productsSold"] = productsSold;

            return View(productsList);
        }

        public async Task<IActionResult> Search(string query)
        {
            var plantPlanetContext = _context.Product.Include(p => p.Supplier).Where(a => a.Name.Contains(query));
            return View("Index", await plantPlanetContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }                        

            var product = await _context.Product
                .Include(p => p.Supplier).Include(p => p.SubCategories)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["subcategories"] = new SelectList(_context.SubCategory, nameof(SubCategory.SubCategoryId) ,nameof(SubCategory.Name));
            ViewData["SupplierId"] = new SelectList(_context.Set<Supplier>(), "SupplierId", "CompanyName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile ImageURL, [Bind("ProductId,Name,Description,Treatment,TreatmentTips,BuyingCost,SellingPrice,SupplierId,Discount,Color,Size,ImageURL,NetIncome,UnitsSold")] Product product, int[] SubCategories)
        {
            if (ModelState.IsValid)
            {
                product.SubCategories = new List<SubCategory>();
                product.SubCategories.AddRange(_context.SubCategory.Where(x => SubCategories.Contains(x.SubCategoryId)));

                if (ImageURL == null)
                {
                    product.ImageURL = DefaultPictureURL;
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    var filename = Path.Combine(_hosting.WebRootPath, Path.GetFileName(ImageURL.FileName));
                    product.ImageURL = ImageURL.FileName;
                    _context.Add(product);
                    ImageURL.CopyTo(new FileStream(filename, FileMode.Create));
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["SupplierId"] = new SelectList(_context.Set<Supplier>(), "SupplierId", "CompanyName", product.SupplierId);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Set<Supplier>(), "SupplierId", "CompanyName", product.SupplierId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile ImageURL, [Bind("ProductId,Name,Description,Treatment,TreatmentTips,BuyingCost,SellingPrice,SupplierId,Discount,Color,Size,Quantity,ImageURL,NetIncome,UnitsSold")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ImageURL == null)
                    {
                        product.ImageURL = _context.Product.Where(p => p.ProductId == id).AsNoTracking().First().ImageURL;
                    }
                    else
                    {
                        var filename = Path.Combine(_hosting.WebRootPath, Path.GetFileName(ImageURL.FileName));
                        product.ImageURL = ImageURL.FileName;
                        ImageURL.CopyTo(new FileStream(filename, FileMode.Create));
                    }

                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["SupplierId"] = new SelectList(_context.Set<Supplier>(), "SupplierId", "CompanyName", product.SupplierId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
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

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
    }
}
