using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class ManagerHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
