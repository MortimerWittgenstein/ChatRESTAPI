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

        public ChatUser(int id, string username)
        {
            Id = id;
            Username = username;
        }

        public bool Connect()
        {
            if (!Authenticate())
                return false;

            TimeConnected = DateTime.Now;
            UserList.Users.Append(this);
            return true;
        }

        private bool Authenticate()
        {
            // TODO
            return true;
        }
    }
}
