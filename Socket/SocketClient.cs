using Ether.Network.Client;
using Ether.Network.Packets;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace POSIDigitalPrinterAPIUtil.Socket
{
    public class SocketClient : NetClient
    {
        const int DEFAULT_BUFFER_SIZE = 4096;

        public SocketClient(string host, int port)
        {
            this.Configuration.Host = host;
            this.Configuration.Port = port;
            this.Configuration.BufferSize = DEFAULT_BUFFER_SIZE;
        }

        public override void HandleMessage(INetPacketStream packet) { }

        public void SendData(String message)
        {
            using (var packet = new NetPacket())
            {
                packet.Write(message);
                this.Send(packet);
            }
        }

        protected override void OnConnected() { }

        protected override void OnDisconnected() { }

        protected override void OnSocketError(SocketError socketError) { }
    }
}
