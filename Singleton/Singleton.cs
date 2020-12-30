using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// Singleton(LoadBalancer)
    /// Defines an Instance operation that lets clients access its unique instance. /// Instance is a class operation.
    /// Responsible for creating and maintaining its own unique instance.
    /// </summary>
    public sealed class LoadBalancer//Singleton
    {
        private static readonly LoadBalancer _instance = 
            new LoadBalancer();

        private List<Server> _servers { get; set; }
        private Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{Name = "Server1", Ip = "120.14.220.18"},
                new Server{Name = "Server2", Ip = "120.14.220.19"},
                new Server{Name = "Server3", Ip = "120.14.220.20"},
                new Server{Name = "Server4", Ip = "120.14.220.21"},
                new Server{Name = "Server5", Ip = "120.14.220.22"},
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        public Server NextServer
        {
            get 
            {
                int random = _random.Next(_servers.Count);
                return _servers[random];
            }
        }
    }

    public class Server
    {
        public string Name { get; set; }
        public string Ip { get; set; }
    }
}
