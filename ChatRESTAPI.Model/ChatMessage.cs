using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRESTAPI.Model
{
    public class ChatMessage
    {
        public int SenderUserId { get; set; }
        public int RecipientUserId { get; set; }
        public string Message { get; set; }
    }
}
