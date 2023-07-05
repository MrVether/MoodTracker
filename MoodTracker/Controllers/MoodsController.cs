using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoodTracker.Controllers
{
    public class MoodsController : Controller
    {
        // GET: MoodsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MoodsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MoodsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoodsController/Create
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

        // GET: MoodsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoodsController/Edit/5
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

        // GET: MoodsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoodsController/Delete/5
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
