using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Models
{
    public class Movement
    {
        [JsonProperty("movement_id")]
        public int MovementId { get; set; }

        [JsonProperty("movement_date")]
        public DateTime MovementDate { get; set; }

        [JsonProperty("movement_type")]
        public string MovementType { get; set; }

        [JsonProperty("movement_value")]
        public double MovementValue { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        public virtual Account Account{ get; set; }
    }
}
