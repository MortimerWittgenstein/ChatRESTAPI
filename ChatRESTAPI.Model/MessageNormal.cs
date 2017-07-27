using ChatRESTAPI.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRESTAPI.Model
{
    public class MessageNormal : Message, ISerializable<MessageNormal>
    {
        public new string Payload => Encoding.UTF8.GetString(base.Payload);

        public MessageNormal(string message) : base(message)
        {
            Tag = "Normal";
            base.Payload = Encoding.UTF8.GetBytes(message);
        }


        public override bool CheckIfOk()
        {
            return true;
        }

        public MessageNormal Deserialize(string value)
        {
            return JsonConvert.DeserializeObject<MessageNormal>(value);
        }

        public string Serialize(MessageNormal obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
