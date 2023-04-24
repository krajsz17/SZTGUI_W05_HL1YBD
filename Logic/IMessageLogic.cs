using Models;
using System.Collections.Generic;

namespace Logic
{
    public interface IMessageLogic
    {
        void Add(Message message);
        IEnumerable<Message> ReadAll();
    }
}