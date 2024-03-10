using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class WriterRepo
    {
        MyDbContext mydb = new MyDbContext();
        public void Create(Writer entity)
        {
            mydb.Writers.Add(entity);
            mydb.SaveChanges();
        }

        public Writer Read(int id)
        {
            var book = mydb.Writers.Find(id);

            if (book == null)
            {
                throw new InvalidOperationException($"Writer with ID {id} not found.");
            }

            return book;
        }

        public void Update(Writer entity)
        {
            mydb.Writers.Update(entity);
        }
        public void Delete(int id)
        {
            var writerToDelete = mydb.Writers.Find(id);


            if (writerToDelete != null)
            {

                mydb.Writers.Remove(writerToDelete);
                mydb.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException($"Writer with ID {id} not found.");
            }

        }

        public List<Writer> ReadAll()
        {

            return mydb.Writers.ToList();
        }
    }
}
