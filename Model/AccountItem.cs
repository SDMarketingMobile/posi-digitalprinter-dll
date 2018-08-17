using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class AccountItem
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
        /// Nome do produto/item
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Quantidade do produto/item
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Tempo de preparo do item
        /// </summary>
        [JsonProperty("prepare_time")]
        public int PrepareTime { get; set; }

        /// <summary>
        /// Descrição do combinado
        /// </summary>
        [JsonProperty("combo_name")]
        public string ComboName { get; set; }

        /// <summary>
        /// Campo destinado ao controle de status do item (uso interno da tela)
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Campo para marcar se o item foi sincronizado 
        /// </summary>
        [JsonProperty("sync")]
        public bool Sync { get; set; }

        /// <summary>
        /// Lista de adicionais do item ou preparos
        /// </summary>
        [JsonProperty("aditionals")]
        public List<AccountItemAditional> Aditionals { get; set; }

        /// <summary>
        /// Dados da tela onde o pedido deve ser produzido
        /// </summary>
        [JsonProperty("remote_device_production")]
        public RemoteDevice RemoteDeviceProduction { get; set; }

        /// <summary>
        /// Dados da tela onde o pedido deve aparecer para conferencia
        /// </summary>
        [JsonProperty("remote_device_conference")]
        public RemoteDevice RemoteDeviceConference { get; set; }

        /// <summary>
        /// Data e Hora em que foi iniciado a produção do item  (gerado automaticamente)
        /// </summary>
        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Data e Hora em que foi finalizado a produção do item (gerado automaticamente)
        /// </summary>
        [JsonProperty("finishedAt")]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Data e Hora em que o item foi removido da conta/tela (gerado automaticamente)
        /// </summary>
        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }
    }
}
