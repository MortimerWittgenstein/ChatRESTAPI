using System.Collections.Generic;
using System.Linq;

namespace ChatRESTAPI.Models
{
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
