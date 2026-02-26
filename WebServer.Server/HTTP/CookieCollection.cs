using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebServer.Server.HTTP
{
    public class CookieCollection : IEnumerable<Cookie>
    {
        private readonly Dictionary<string, Cookie> cookies;

        public CookieCollection()
        {
            cookies = new Dictionary<string, Cookie>();
        }

        public string this[string name]
        {
            
        }
        public void Add(string name, string value)
        {
            cookies[name] = new Cookie(name, value);
        }

        public bool
        public IEnumerator<Cookie> GetEnumerator()
        {
            return cookies.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
