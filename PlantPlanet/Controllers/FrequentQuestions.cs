using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class FrequentQuestions : Controller
    {
        // GET: FrequentQuestions
        public ActionResult Index()
        {
            return View();
        }
    }
}
