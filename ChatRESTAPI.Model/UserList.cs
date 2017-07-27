using System.Collections.Generic;
using System.Linq;

namespace ChatRESTAPI.Model
{
    public class UserList
    {
        public static IEnumerable<ChatUser> Users { get; set; }
    }
}
