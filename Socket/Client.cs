using Ether.Network.Common;
using Ether.Network.Packets;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSIDigitalPrinterAPIUtil.Socket
{
    public class Client : NetUser
    {
        public delegate void DataReceived(string data);
        public event DataReceived OnDataReceived;

        public override void HandleMessage(INetPacketStream packet) {
            var data_received = packet.Read<string>();
            OnDataReceived?.Invoke(data_received);
        }
    }
}
