using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class RemoteDevice
    {
        /// <summary>
        /// Campo interno da API (gerado automaticamente)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Campo destinado para referencia e identificação externa
        /// </summary>
        [JsonProperty("pid")]
        public int Pid { get; set; }

        /// <summary>
        /// Nome/Descrição da tela/remota
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// IP da Remota
        /// </summary>
        [JsonProperty("device_ip")]
        public string DeviceIP { get; set; }

        /// <summary>
        /// Porta da Remota
        /// </summary>
        [JsonProperty("device_port")]
        public int DevicePort { get; set; }

        /// <summary>
        /// IP da Impressora Mestra
        /// </summary>
        [JsonProperty("mestra_ip")]
        public string MestraIP { get; set; }
       
        /// <summary>
        /// Porta da Impressora Mestra
        /// </summary>
        [JsonProperty("mestra_port")]
        public int MestraPort { get; set; }
    }
}
