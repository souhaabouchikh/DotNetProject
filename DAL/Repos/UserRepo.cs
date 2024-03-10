using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UserRepo
    {
        MyDbContext mydb = new MyDbContext();
        public void Create(User entity)
        {
            mydb.Users.Add(entity);
            mydb.SaveChanges();
        }

        public User Read(int id)
        {
            var user = mydb.Users.Find(id);

            if (user == null)
            {
                throw new InvalidOperationException($"User with ID {id} not found.");
            }

            return user;
        }

        public void Update(User entity)
        {
            mydb.Users.Update(entity);
        }
        public void Delete(int id)
        {
            var UserToDelete = mydb.Users.Find(id);


            if (UserToDelete != null)
            {

                mydb.Users.Remove(UserToDelete);
                mydb.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException($"User with ID {id} not found.");
            }

        }

        public List<User> ReadAll()
        {
            return mydb.Users.ToList();
        }


        public User UserLogin(string email,string pass)
        {
            var user = mydb.Users.FirstOrDefault(a => a.Email == email && a.Password == pass);

            if (user == null)
            {
                throw new InvalidOperationException($"User with this login not found.");
            }

            return user;
        }

        public User Adminlogin(string email, string pass)
        {
            var user = mydb.Users.FirstOrDefault(a => a.Email == email && a.Password == pass && a.isAdmin==true);

            if (user == null)
            {
                throw new InvalidOperationException($"Admin with this login not found.");
            }

            return user;
        }
    }
}
