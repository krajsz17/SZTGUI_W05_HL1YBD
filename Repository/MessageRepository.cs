using Models;
using System.Collections.Generic;

namespace Repository
{
    public class MessageRepository : Repository<MessageModels>, IRepository<MessageModels>
    {
        public MessageRepository(IEnumerable<MessageModels> items) : base(items) { }
    }
}
