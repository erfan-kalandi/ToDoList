using library;
using Microsoft.AspNetCore.SignalR;
public class HubConnection : Hub 
{ 
    public async Task MakeConnection() 
    { 
        await Clients.All.SendAsync("RefreshUI"); 
    } 
} 