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
            //getting all the stores' information from the dB
            IList<Store> StoresList = new List<Store>();
            StoresList = _context.Store.ToArray();

            //creating the array of addresses for the map
            string markers = "[";
            foreach (var item in StoresList)
            {
                markers += "{";
                markers += string.Format("'description': '{0}',", item.StoreName);
                markers += string.Format("'lat': '{0}',", item.StoreLocationX);
                markers += string.Format("'lng': '{0}',", item.StoreLocationY);
                markers += "},";
            }
            markers += "]";
            ViewBag.Markers = markers;

            return View();
        }

        public void SubmitForm(object sender, System.EventArgs e)
        {
            String privateName = Request.Form["privateName"];
            String familyName = Request.Form["familyName"];
            String email = Request.Form["email"];
            String phone = Request.Form["phone"];
            String reason = Request.Form["reason"];
        }

    }
}
