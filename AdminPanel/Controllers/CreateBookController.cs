using Microsoft.AspNetCore.Mvc;
using Models;

namespace AdminPanel.Controllers
{
    public class CreateBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index"); // Redirect to the list page or another relevant action
            }

            // If ModelState is not valid, redisplay the form with validation errors
            return View(model);
        }

    }
}
