using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoodTracker.Controllers
{
    public class ResourcesController : Controller
    {
        // GET: ResourcesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ResourcesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResourcesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResourcesController/Create
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

        // GET: ResourcesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResourcesController/Edit/5
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

        // GET: ResourcesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResourcesController/Delete/5
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
