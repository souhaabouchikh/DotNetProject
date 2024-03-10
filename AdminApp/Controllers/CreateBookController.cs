using Microsoft.AspNetCore.Mvc;
using Models;
using BLL;


namespace AdminPanel.Controllers
{
    public class CreateBookController : Controller
    {

        public IActionResult Index()
        {
            BLL.CategoryService categoryService = new BLL.CategoryService();
            BLL.WriterService writerService = new BLL.WriterService();
            ViewBag.Writers = writerService.ListWriters();
            ViewBag.Cats = categoryService.ListAllCategory();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookViewModel model)
        {
            string stringFileName=UploadFile(model);
            model.BookImage = stringFileName;
            BookViewModel finalmodel = new BookViewModel
            {
                AddingTime = DateTime.Now,
                Title = model.Title,
                Description = model.Description,
                Year = model.Year,
                Price = model.Price,
                IdCategory = model.IdCategory,
                BookImage = stringFileName,
                DiscountPrice = model.DiscountPrice,
                Disponibility = model.Disponibility,
                isDiscounted = model.isDiscounted,
                Writer = model.Writer
            };
            BLL.BookService bookService = new BLL.BookService();
            bookService.Create(finalmodel);
            return RedirectToAction("Index", "Dash");
        }

        private string UploadFile(BookViewModel model)
        {
            string fileName = null;
            if(model.Image!= null)
            {
                string uploadDir = Path.Combine("wwwroot", "Images");
                fileName= Guid.NewGuid().ToString() + "_" +model.Image.FileName;
                string filePath= Path.Combine(uploadDir,fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                   model.Image.CopyTo(fileStream);
                }
                return fileName;

            }
            return fileName;
        }
    }
}
