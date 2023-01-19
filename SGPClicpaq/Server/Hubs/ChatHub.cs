using Microsoft.AspNetCore.SignalR;

namespace SGPClicpaq.Server.Hubs
{
    public class ChatHub : Hub 
    {
        public async Task SendMessage(string room, string user, string message)
        {
            await Clients.Group(room).SendAsync("ReceiveMessage", user, message);
        }
        public async Task AddToGroup(string room)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
            await Clients.Group(room).SendAsync("ReceiveInformation", "ASDJA");
            //await Clients.Group(room).SendAsync("ShowWho", $"Se conecto {Context.ConnectionId}");

            //acá llenamos la tabla de hanghells cuando se conecta 1?
        }

        public async Task Send(string text)
        {
            Console.WriteLine("HOLA HUB 2");

            await Clients.All.SendAsync("ReceiveInformation", text);
        }

    }
}
