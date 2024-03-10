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
    public class MessageService
    {
        public List<Models.MessageViewModel> ListAllMessages()
        {
            var list = new List<Models.MessageViewModel>();

            MessageRepo repos = new MessageRepo();



            foreach (var item in repos.ReadAll())
            {
                MessageViewModel obj = new MessageViewModel()
                { Id = item.Id, message = item.message, Subject = item.Subject,Name=item.Name,email=item.email};
                list.Add(obj);
            }

            return list;

        }

        public bool Create(Models.MessageViewModel obj)
        {
            var source = new MessageRepo();
            Message message = new Message();
            message.Id = obj.Id;
            message.Subject = obj.Subject;
            message.message=obj.message;
            message.email = obj.email;
            message.Name = obj.Name;
            source.Create(message);
            return true;
        }
    }
}
