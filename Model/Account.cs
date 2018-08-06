using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class Account
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; }

        [JsonProperty("finishedAt")]
        public DateTime? FinishedAt { get; set; }

        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        [JsonProperty("items")]
        public List<AccountItem> Items { get; set; }
    }
}
