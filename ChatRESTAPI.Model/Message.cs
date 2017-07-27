using ChatRESTAPI.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRESTAPI.Model
{ 
    public abstract class Message : ITagable
    {
        public int Type { get; protected set; }
        public string Tag { get; protected set; }
        public byte[] Payload { get; protected set; }

        public Message(string message)
        {

        }

        public virtual void HelloWorld()
        {
            
        }

        public abstract bool CheckIfOk();
    }
}
