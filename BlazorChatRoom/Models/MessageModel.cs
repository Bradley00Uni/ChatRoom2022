using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatRoom.Data
{
    public class MessageModel
    {
        public Guid Id { get; set; }

        public string Sender { get; set; }

        public string MessageBody { get; set; }

        public DateTime TimeStamp { get; set; }

    }

   

}
