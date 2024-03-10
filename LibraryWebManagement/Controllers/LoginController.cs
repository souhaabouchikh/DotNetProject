using Microsoft.AspNetCore.Mvc;
using BLL;
using Models;

namespace LibraryWebManagement.Controllers
{
    public class LoginController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            // Redirect to a desired page after sign-out
            return RedirectToAction("Index", "Home");
        }



        [HttpPost]
        public IActionResult LForm()
        {
            UserService service = new UserService();
            UserViewModel model = new UserViewModel();

            model.Email = HttpContext.Request.Form["email"];
            model.Password = HttpContext.Request.Form["pass"];
            int id = service.VerifyUser(model.Email, model.Password);

            UserViewModel userViewModel = service.Detail(id);

            HttpContext.Session.SetInt32("Id", userViewModel.Id);
            HttpContext.Session.SetString("Name", userViewModel.FirstName);
            HttpContext.Session.SetString("Last", userViewModel.LastName);
            HttpContext.Session.SetString("Email", userViewModel.Email);

            return RedirectToAction("Index", "Home");


        }

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
    }

}
