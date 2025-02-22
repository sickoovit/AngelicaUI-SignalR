using Microsoft.AspNetCore.SignalR;

namespace AngelicaUI_SignalR.Hubs;

public class ChatHub : Hub
{
	public async Task SendMessage(string fromUser, string message)
	{
		await Clients.All.SendAsync("RecieveMessage", fromUser, message);
	}
}
