using ChatRESTAPI.Core;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRESTAPI.Model
{
    public class ChatUser : ITagable
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public DateTime TimeConnected { get; private set; }

        public string Tag => "User";

        public bool Connect()
        {
            TimeConnected = DateTime.Now;
            UserList.Add(this);
            return true;
        }
    }
}
