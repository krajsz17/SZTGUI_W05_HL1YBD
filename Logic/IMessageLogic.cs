using Models;
using System.Collections.Generic;

namespace Logic
{
    public interface IMessageLogic
    {
        void Add(MessageModels message);
        IEnumerable<MessageModels> ReadAll();
    }
}