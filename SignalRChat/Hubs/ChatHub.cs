
using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub:Hub
    {

        public async Task SendMessage(string message, string userName)
        {
            await Clients.All.SendAsync("ReceiveMessage", userName, message);
        }

    }
}
