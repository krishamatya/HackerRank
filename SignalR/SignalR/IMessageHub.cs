using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR
{
   public interface IMessageHub
    {
        Task ReceiveMessage(string user, string message);
    }

}
