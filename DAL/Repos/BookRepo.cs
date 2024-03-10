using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class BookRepo
    {
        MyDbContext mydb = new MyDbContext();
        public void Create(Book entity)
        {
            mydb.Books.Add(entity);
            mydb.SaveChanges();
        }

        public Book Read(int id)
        {
            var book = mydb.Books.Find(id);

            if (book == null)
            {
                throw new InvalidOperationException($"Book with ID {id} not found.");
            }

            return book;
        }

        public void Update(Book entity)
        {
            mydb.Books.Update(entity);
        }
        public void Delete(int id)
        {
            var BookToDelete = mydb.Books.Find(id);


            if (BookToDelete != null)
            {

                mydb.Books.Remove(BookToDelete);
                mydb.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException($"Book with ID {id} not found.");
            }

        }

        public List<Book> ReadAll()
        {
            return mydb.Books.ToList();
        }
    }
}
