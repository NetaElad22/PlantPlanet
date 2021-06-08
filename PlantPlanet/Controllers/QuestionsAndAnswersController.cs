using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantPlanet.Controllers
{
    public class QuestionsAndAnswersController : Controller
    {
        // GET: QuestionsAndAnswersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuestionsAndAnswersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionsAndAnswersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionsAndAnswersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionsAndAnswersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionsAndAnswersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestionsAndAnswersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionsAndAnswersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
