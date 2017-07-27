using ChatRESTAPI.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRESTAPI.Model
{
    public class MessagePrivate : Message, ISerializable<MessagePrivate> 
    {
        public new string Payload => Encoding.UTF8.GetString(base.Payload);

        public MessagePrivate(string message) : base(message)
        {
            Tag = "Private";
            base.Payload = Encoding.UTF8.GetBytes(message);
        }
        

        public override bool CheckIfOk()
        {
            return true;
        }

        public MessagePrivate Deserialize(string value)
        {
            return JsonConvert.DeserializeObject<MessagePrivate>(value);
        }

        public string Serialize(MessagePrivate obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
