using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class MessagesHub:Hub
    {
        private readonly static ConnectionMapping<string> _connections =
            new ConnectionMapping<string>();
       
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override async Task OnConnectedAsync()
        {
            string name = Context.User.Identity.Name;
            _connections.Add(name, Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            string name = Context.User.Identity.Name;
            var cIds = _connections.GetConnections(name);
            _connections.Remove(name, Context.ConnectionId);
            Context.Abort();
        
            await base.OnDisconnectedAsync(exception);
        }
      
    }
}
