using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class AccountItemAditional
    {
        /// <summary>
        /// Descrição do adicional/preparo
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
