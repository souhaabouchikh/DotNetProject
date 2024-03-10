using Microsoft.AspNetCore.Mvc;

namespace LibraryWebManagement.Controllers
{
    public class ProfilController : Controller
    {
        public bool LoggedIn()
        {
            if (HttpContext.Session.TryGetValue("Id", out var elementValue) && elementValue != null && elementValue.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public IActionResult Index()
        {
            if (LoggedIn())
            {
                string id = HttpContext.Session.GetString("Id");
                string email = HttpContext.Session.GetString("Email");
                string last = HttpContext.Session.GetString("Last");
                string first = HttpContext.Session.GetString("Name");



                // Use the retrieved data (e.g., pass it to a view)
                ViewBag.id = id;
                ViewBag.email = email;
                ViewBag.last = last;
                ViewBag.first = first;

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

           
        }
    }
}
