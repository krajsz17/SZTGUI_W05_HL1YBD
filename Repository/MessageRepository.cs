using Models;
using System.Collections.Generic;

namespace Repository
{
    public class MessageRepository : Repository<Message>, IRepository<Message>
    {
        public MessageRepository(IEnumerable<Message> items) : base(items) { }
    }
}
