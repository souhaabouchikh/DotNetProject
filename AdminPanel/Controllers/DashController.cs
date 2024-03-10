using BLL;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class DashController : Controller
    {
        public IActionResult Index()
        {
            BookService bookService = new BookService();
            var model = bookService.ListBooks();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            BookService bookService = new BookService();
            bookService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
