using Microsoft.AspNetCore.Mvc;
using BLL;
using Models;
namespace LibraryWebManagement.Controllers
{
    public class InscriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InscriptionForm()
        {
            UserService service = new UserService();
            UserViewModel model = new UserViewModel();
            model.FirstName = HttpContext.Request.Form["fname"];
            model.LastName = HttpContext.Request.Form["lname"];
            model.Email = HttpContext.Request.Form["email"];
            model.Password = HttpContext.Request.Form["pass"];

            if (service.Create(model))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Login", "Inscription");
            }

        }
    }
}
