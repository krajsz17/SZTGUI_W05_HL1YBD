using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MessageLogic : IMessageLogic
    {
        IRepository<Message> repository;
        public MessageLogic(IRepository<Message> repository)
        {
            this.repository = repository;
        }

        public void Add(Message message)
        {
            this.repository.Add(message);
        }

        public IEnumerable<Message> ReadAll()
        {
            return repository.ReadAll();
        }

    }
}
