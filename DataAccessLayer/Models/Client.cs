using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Models;

namespace DataAccessLayer.Models
{
    public class Client
    {
        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("state")]
        public bool State { get; set; }

        [JsonProperty("person_id")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public virtual Account Account { get; set; }
    }
}
