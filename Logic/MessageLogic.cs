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
        IRepository<MessageModels> repository;
        public MessageLogic(IRepository<MessageModels> repository)
        {
            this.repository = repository;
        }

        public void Add(MessageModels message)
        {
            this.repository.Add(message);
        }

        public IEnumerable<MessageModels> ReadAll()
        {
            return repository.ReadAll();
        }

    }
}
