using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class AccountItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("prepare_time")]
        public int PrepareTime { get; set; }

        [JsonProperty("combo_name")]
        public string ComboName { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("sync")]
        public bool Sync { get; set; }

        [JsonProperty("aditionals")]
        public List<AccountItemAditional> Aditionals { get; set; }

        [JsonProperty("remote_device_production")]
        public RemoteDevice RemoteDeviceProduction { get; set; }

        [JsonProperty("remote_device_conference")]
        public RemoteDevice RemoteDeviceConference { get; set; }

        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; set; }

        [JsonProperty("finishedAt")]
        public DateTime? FinishedAt { get; set; }

        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }
    }
}
