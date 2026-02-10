using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using WebServer.Server.HTTP_Request;

namespace WebServer.Server.HTTP
{
    public class RoutingTable : IRoutingTable
    {
        private readonly Dictionary<Method, Dictionary<string, Response>> routes;
        public RoutingTable(Dictionary<Method, Dictionary<string, Response>> routes)
        {
            
        }

        public IRoutingTable Map(string url, Method method, Response response)
        {
            throw new NotImplementedException();
        }

        public IRoutingTable MapGet(string url, Response response)
        {
            throw new NotImplementedException();
        }

        public IRoutingTable MapPost(string url, Response response)
        {
            throw new NotImplementedException();
        }
    }
}
