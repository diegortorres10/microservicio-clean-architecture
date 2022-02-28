using Newtonsoft.Json;

namespace DataAccessLayer.Models
{
    public class Account
    {
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("account_number")]
        public int AccountNumber { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("initial_balance")]
        public double InitialBalance { get; set; }

        [JsonProperty("state")]
        public bool State { get; set; }

        [JsonProperty("client_id")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public virtual Movement Movement { get; set; }
    }
}
