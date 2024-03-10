using DAL.Repos;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public List<Models.CategoryViewModel> ListAllCategory()
        {
            var list = new List<Models.CategoryViewModel>();

            CategoryRepo repos = new CategoryRepo();



            foreach (var item in repos.ReadAll())
            {
                CategoryViewModel obj = new CategoryViewModel()
                { Id = item.Id, CategoryName = item.CategoryName, CategoryPicture = item.CategoryName};
                list.Add(obj);
            }

            return list;

        }
    }
}
