using Ether.Network.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSIDigitalPrinterAPIUtil.Socket
{
    public class SocketServer : NetServer<Client>
    {
        const int DEFAULT_MAX_CONNECTIONS = 100;
        const int DEFAULT_BUFFER_SIZE = 4096;

        public SocketServer(string host, int port)
        {
            this.Configuration.Backlog = 100;
            this.Configuration.Port = port;
            this.Configuration.MaximumNumberOfConnections = DEFAULT_MAX_CONNECTIONS;
            this.Configuration.Host = host;
            this.Configuration.BufferSize = DEFAULT_BUFFER_SIZE;
            this.Configuration.Blocking = true;
            
        }

        protected override void Initialize() { }

        protected override void OnClientConnected(Client connection) { }

        protected override void OnClientDisconnected(Client connection) { }

        protected override void OnError(Exception exception) { }
    }
}
