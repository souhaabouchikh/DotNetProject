using BLL;
using DAL.Repos;
using Microsoft.AspNetCore.Mvc;

namespace LibraryWebManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            if (id == null) { return NotFound(); }

            BookService bookService = new BookService();
            var model = bookService.ListByCategory(id);
            return View(model);
        }
        public IActionResult Detail(int id)
        {

            if (id == null) { return NotFound(); }

            BookService bookService = new BookService();
            var model = bookService.Detail(id);
            ViewData["Title"] = model.Title;
            ViewData["Description"] = model.Description;


            return View(model);
        }
        public IActionResult Liste(int id)
        {

            if (id == 0)
            {
                return NotFound();
            }
            BookService bookService = new BookService();


            ViewData["TitrePage"] = $"Les livres de la categorie {id}";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";

            return View(bookService.ListByCategory(id));
        }
    }
}
