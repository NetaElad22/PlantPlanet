using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
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
