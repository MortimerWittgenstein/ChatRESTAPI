using System;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRESTAPI.Model
{
    public class ChatUser
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public DateTime TimeConnected { get; private set; }

        public bool Connect()
        {
            TimeConnected = DateTime.Now;
            UserList.Add(this);
            return true;
        }
    }
}
