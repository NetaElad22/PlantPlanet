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
    public class ContactController : Controller
    {
        private readonly PlantPlanetContext _context;

        public ContactController(PlantPlanetContext context)
        {
            _context = context;
        }
        // GET: ContactController
        public ActionResult Index()
        {

            return View();
        }
    }
}
