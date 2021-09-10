using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class FacebookController : Controller
    {
        [Authorize(Roles = "Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
