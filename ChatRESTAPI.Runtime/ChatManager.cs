using ChatRESTAPI.Core;
using ChatRESTAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRESTAPI.Runtime
{
    public static class ChatManager
    {

        private static Database.Database database;

        static ChatManager()
        {
            database = new Database.Database("");
        }


        public static string GetUserById(int id) => database.User;
               

        public static string Serialize<T>(T message) where T : ISerializable<T>
        {
            return message.Serialize(message);
        }

        public static void Send(Message message)
        {
            string response;
            if (message is MessagePrivate pm)
                response = Serialize(pm);
            else
                response = message.Tag;
        }
    }
}
