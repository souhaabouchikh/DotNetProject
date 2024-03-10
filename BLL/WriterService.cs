using DAL.Repos;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WriterService
    {
        public List<Models.WriterViewModel> ListWriters()
        {
            var list = new List<Models.WriterViewModel>();

            WriterRepo repos = new WriterRepo();



            foreach (var item in repos.ReadAll())
            {
                WriterViewModel obj = new WriterViewModel()
                { Id=item.Id,FirstName = item.FirstName, LastName = item.LastName, DateOfBirth = item.DateOfBirth, Nationality = item.Nationality, Bio = item.Bio };
                list.Add(obj);
            }

            return list;

        }
    }
}
