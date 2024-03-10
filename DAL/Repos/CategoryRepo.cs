using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        MyDbContext mydb = new MyDbContext();
        public void Create(Category entity)
        {
            mydb.Categories.Add(entity);
            mydb.SaveChanges();
        }

        public Category Read(int id)
        {
            var category = mydb.Categories.Find(id);

            if (category == null)
            {
                throw new InvalidOperationException($"Category with ID {id} not found.");
            }

            return category;
        }

        public void Update(Category entity)
        {
            mydb.Categories.Update(entity);
        }
        public void Delete(int id)
        {
            var CategoryToDelete = mydb.Categories.Find(id);


            if (CategoryToDelete != null)
            {

                mydb.Categories.Remove(CategoryToDelete);
                mydb.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException($"Category with ID {id} not found.");
            }

        }

        public List<Category> ReadAll()
        {
            return mydb.Categories.ToList();
        }
    }
}
