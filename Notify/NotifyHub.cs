using Microsoft.AspNetCore.SignalR;

namespace SignalRApp.Notify

{
    public class NotifyHub:Hub
    {
        public async Task SendNotification(string name,string message)
        {
            await Clients.All.SendAsync("NotifyAll",name, message);

        }
    }
}
