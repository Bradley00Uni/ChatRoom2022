using BlazorChatRoom.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatRoom.Models
{
    public class RoomModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UserModel> OnlineUsers { get; set; } = new List<UserModel>();
        public List<MessageModel> Messages = new List<MessageModel>();
        public UserModel CreatedBy { get; set; }
    }
}
