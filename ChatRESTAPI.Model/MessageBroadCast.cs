using ChatRESTAPI.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRESTAPI.Model
{
    public class MessageBroadCast : Message, ISerializable<MessageBroadCast>
    {
        public new string Payload => Encoding.UTF8.GetString(base.Payload);

        public MessageBroadCast(string message) : base(message)
        {
            Tag = "BroadCast";
            base.Payload = Encoding.UTF8.GetBytes(message);
        }


        public override bool CheckIfOk()
        {
            return true;
        }

        public MessageBroadCast Deserialize(string value)
        {
            return JsonConvert.DeserializeObject<MessageBroadCast>(value);
        }

        public string Serialize(MessageBroadCast obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}