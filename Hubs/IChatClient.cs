using Microsoft.AspNetCore.SignalR;

namespace ChatRoomSignalR.Hubs;

public interface IChatClient {
    Task MessageReceiver(string user, string message);
}