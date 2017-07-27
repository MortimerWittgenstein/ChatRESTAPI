using ChatRESTAPI.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatRESTAPI.Database
{
    public class Database : IDatabase
    {
        public string User => "Test";

        public Database(string sqlConnectionString)
        {

        }
    }
}
