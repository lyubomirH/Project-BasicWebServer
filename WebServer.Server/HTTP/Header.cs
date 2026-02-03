using System;
using System.Collections.Generic;
using System.Text;

namespace WebServer.Server.HTTP
{
    public class Header
    {
        public Header(string name, string value)
        {

            this.Name = name;
            this.Value = value;

        }

        public string Name { get; init; }
        public string Value { get; set; }
        //2. Create Additional Classes
        //https://classroom.google.com/w/Nzc1MDIzNjgzMzg1/t/ODA2MjkyNTUwNjIx
    }
}
