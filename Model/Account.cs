using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using POSIDigitalPrinterAPIUtil.Enumerator;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class Account
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
        /// Declaração do tipo de conta
        /// </summary>
        [JsonProperty("type")]
        public AccountType Type { get; set; }

        /// <summary>
        /// Campo destinado ao número de identificação da conta
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// Campo destinado ao controle de status da conta (uso interno da tela)
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Data e Hora da inclusão do pedido na tela (gerado automaticamente)
        /// </summary>
        [JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data e Hora da finalização do pedido pela tela (gerado automaticamente)
        /// </summary>
        [JsonProperty("finishedAt")]
        public DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Data e Hora de algum pedido que foi removido da tela (gerado automaticamente)
        /// </summary>
        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Lista de items da conta
        /// </summary>
        [JsonProperty("items")]
        public List<AccountItem> Items { get; set; }
    }
}
