using DAL.Entity;
using DAL.Repos;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookService
    {
        //this class gets the methods from the repos that use the entities directly,
        //and they put them inside other methods
        //just another layer of protection...i guess.
        public List<Models.BookViewModel> ListByCategory(int idCategorie)
        {
            var list = new List<Models.BookViewModel>();

            BookRepo repos = new BookRepo();



            foreach (var item in repos.ReadAll().Where(a => a.IdCategory == idCategorie))
            {
                BookViewModel obj = new BookViewModel()
                { Description = item.Description, Id = item.Id, Title = item.Title, Price = item.Price,BookImage=item.BookImage};
                list.Add(obj);
            }

            return list;

        }
        public List<Models.BookViewModel> ListBooks()
        {
            var list = new List<Models.BookViewModel>();

            BookRepo repos = new BookRepo();



            foreach (var item in repos.ReadAll())
            {
                BookViewModel obj = new BookViewModel()
                { Description = item.Description, Id = item.Id, Title = item.Title, BookImage = item.BookImage, Price = item.Price,Writer=item.WriterId };
                list.Add(obj);
            }

            return list;

        }

        public BookViewModel Detail(int id)
        {
            var source = new BookRepo();
            var objSource = source.Read(id);


            BookViewModel obj = new BookViewModel();

            obj.Id = objSource.Id;
            obj.Description = objSource.Description;
            obj.Price = objSource.Price;
            obj.BookImage = objSource.BookImage;


            return obj;
        }

        public void Create(Models.BookViewModel obj)
        {
            var source = new BookRepo();
            Book book = new Book();
            book.Price = obj.Price;
            book.Description = obj.Description;
            book.AddingTime = DateTime.Now;
            book.Title = obj.Title;
            book.IdCategory   = obj.IdCategory;
            book.BookImage = obj.BookImage;
            book.WriterId = obj.Writer;
            book.Disponibility = obj.Disponibility;
            book.isDiscounted=obj.isDiscounted;
            book.DiscountPrice= obj.DiscountPrice;
            source.Create(book);
        }

        public void Delete(int ID)
        {
           var source = new BookRepo();
           source.Delete(ID);
        }
    }
}
