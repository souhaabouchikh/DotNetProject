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
    public class UserService
    {

        public int VerifyAdmin(String email, String password)
        {


            UserRepo repos = new UserRepo();
            UserViewModel vm = new UserViewModel();
            var obj = repos.Adminlogin(email, password);
            vm.Id = obj.Id;
            vm.FirstName = obj.FirstName;
            vm.LastName = obj.LastName;
            vm.Email = obj.Email;
            vm.Password = obj.Password;

            return vm.Id;

        }
        public int VerifyUser(String email,String password)
        {
            

            UserRepo repos = new UserRepo();
            UserViewModel vm = new UserViewModel();
            var obj = repos.UserLogin(email, password);
            vm.Id = obj.Id;
            vm.FirstName=obj.FirstName;
            vm.LastName=obj.LastName;
            vm.Email=obj.Email;
            vm.Password=obj.Password;

            return vm.Id;

        }
        public UserViewModel Detail(int id)
        {
            var source = new UserRepo();
            var objSource = source.Read(id);


            UserViewModel obj = new UserViewModel();

            obj.Id = objSource.Id;
            obj.Email = objSource.Email;
            obj.LastName=objSource.LastName;
            obj.FirstName=objSource.FirstName;
            obj.isAdmin = objSource.isAdmin;
            obj.RegistrtionDate = objSource.RegistrationDate;


            return obj;
        }

        public bool Create(Models.UserViewModel obj)
        {
            var source = new UserRepo();
            User user = new User();
            user.Id = obj.Id;
            user.Email = obj.Email;
            user.LastName = obj.LastName;
            user.FirstName = obj.FirstName;
            user.Password = obj.Password;
            user.isAdmin = false;
            source.Create(user);
            return true;
        }

        public bool CreateAdmin(Models.UserViewModel obj)
        {
            var source = new UserRepo();
            User user = new User();
            user.Id = obj.Id;
            user.Email = obj.Email;
            user.LastName = obj.LastName;
            user.FirstName = obj.FirstName;
            user.Password = obj.Password;
            user.isAdmin = true;
            source.Create(user);
            return true;
        }
    }
}
