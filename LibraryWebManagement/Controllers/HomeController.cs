using BLL;
using LibraryWebManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace LibraryWebManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CategoryService service= new CategoryService();
            return View(service.ListAllCategory());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage()
        {
            MessageService messageService = new MessageService();

            string name= HttpContext.Request.Form["name"];
            string email= HttpContext.Request.Form["email"];
            string subject= HttpContext.Request.Form["subject"];
            string message= HttpContext.Request.Form["message"];

            MessageViewModel messageViewModel= new MessageViewModel();
            messageViewModel.message = message;
            messageViewModel.Subject = subject;
            messageViewModel.email = email;
            messageViewModel.Name = name;
            messageService.Create(messageViewModel);

            return RedirectToAction("Index", "Home");
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
