using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRESTAPI.Models
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

    public class UserList
    {
        public static IEnumerable<ChatUser> Users { get; }

        public static void Add (ChatUser User)
        {
            Users.Append(User);
        }

        public static void Remove (int UserId)
        {
            
        }
    }
}
