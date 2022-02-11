using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatRoom.Models
{
    public class CurrentUser
    {
        public UserModel User { get; set; } = new UserModel();
    }
}
