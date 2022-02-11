using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorChatRoom.Data;
using Microsoft.AspNetCore.SignalR;

namespace BlazorChatRoom.Hubs
{
    public class ChatHub : Hub
    {
        public static string HubPath = "/chatroom";

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} Connected!");

            return base.OnConnectedAsync(); //Connected to the main hub
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            Console.WriteLine($"{Context.ConnectionId} Disconnected!");
            await base.OnDisconnectedAsync(exception); //Disconnected from the main hub
        }

        public async Task SendMessage(MessageModel message)
        {
            await Clients.All.SendAsync("RecieveMessage", message);
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
            Console.WriteLine($"{Context.ConnectionId} added to group {groupName}");
        }

        public async void UpdateGroup (string groupName)
        {
            await Clients.GroupExcept(groupName, Context.ConnectionId).SendAsync("UpdateGroup");
        }

    }
}
