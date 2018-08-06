using System;
using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class AccountItemAditional
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
