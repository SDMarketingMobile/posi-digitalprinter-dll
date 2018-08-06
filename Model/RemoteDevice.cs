using System;
using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class RemoteDevice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("device_ip")]
        public string DeviceIP { get; set; }

        [JsonProperty("device_port")]
        public int DevicePort { get; set; }

        [JsonProperty("mestra_ip")]
        public string MestraIP { get; set; }
       
        [JsonProperty("mestra_port")]
        public int MestraPort { get; set; }

        [JsonProperty("websocket_id")]
        public string WebSocketId { get; set; }

        [JsonProperty("view_mode")]
        public string ViewMode { get; set; }
    }
}
