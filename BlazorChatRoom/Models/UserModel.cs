using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatRoom.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string UserId { get; set; }
        public bool Online { get; set; }
    }
}
