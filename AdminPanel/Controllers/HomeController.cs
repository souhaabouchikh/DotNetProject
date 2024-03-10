using AdminPanel.Models;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace AdminPanel.Controllers
{
    [Route("Login")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LForm()
        {
            UserService service = new UserService();
            UserViewModel model = new UserViewModel();

            model.Email = HttpContext.Request.Form["email"];
            model.Password = HttpContext.Request.Form["pass"];
            int id = service.VerifyAdmin(model.Email, model.Password);

            UserViewModel userViewModel = service.Detail(id);

            HttpContext.Session.SetInt32("Id", userViewModel.Id);
            HttpContext.Session.SetString("Name", userViewModel.FirstName);
            HttpContext.Session.SetString("Last", userViewModel.LastName);
            HttpContext.Session.SetString("Email", userViewModel.Email);


            return RedirectToAction("Index", "Dash");


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
