using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatRoom.Models
{
    public class RoomHubModel
    {
        public Dictionary<Guid, RoomModel> ChatRooms { get; set; } = new Dictionary<Guid, RoomModel>();
    }
}
