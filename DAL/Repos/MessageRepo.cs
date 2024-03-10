using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class MessageRepo
    {
        MyDbContext mydb = new MyDbContext();
        public void Create(Message entity)
        {
            mydb.Messages.Add(entity);
            mydb.SaveChanges();
        }

        public Message Read(int id)
        {
            var message = mydb.Messages.Find(id);

            if (message == null)
            {
                throw new InvalidOperationException($"Message with ID {id} not found.");
            }

            return message;
        }

        public void Update(Message entity)
        {
            mydb.Messages.Update(entity);
        }
        public void Delete(int id)
        {
            var MessageToDelete = mydb.Messages.Find(id);


            if (MessageToDelete != null)
            {

                mydb.Messages.Remove(MessageToDelete);
                mydb.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException($"Message with ID {id} not found.");
            }

        }

        public List<Message> ReadAll()
        {
            return mydb.Messages.ToList();
        }
    }
}
