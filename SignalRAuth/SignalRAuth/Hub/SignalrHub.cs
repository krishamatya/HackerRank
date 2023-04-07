using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
namespace SignalRAuth
{
    public class SignalrHub : Hub
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
            var cIds = _connections.GetConnections(name).ToList();
            cIds.ForEach(x => {
                _connections.Remove(name, x);
            });
           

            Context.Abort();

            await base.OnDisconnectedAsync(exception);
        }
    }
}
