using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Services.ViewModels
{
    public class CommonModel
    {
        public class PersonModel
        {
 
            [JsonProperty("name")]
            [Required]
            public string Name { get; set; }

            [JsonProperty("gender")]
            [Required]
            public string Gender { get; set; }

            [JsonProperty("age")]
            [Required]
            public int Age { get; set; }

            [JsonProperty("identification")]
            [Required]
            public string Identification { get; set; }

            [JsonProperty("address")]
            [Required]
            public string Address { get; set; }

            [JsonProperty("phone")]
            [Required]
            public string Phone { get; set; }
        }

        public class ClientModel
        {
            [JsonProperty(PropertyName = "client_id")]
            public int ClientId { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }

            [JsonProperty("state")]
            public bool State { get; set; }

            [JsonProperty("person_name")]
            public string PersonName { get; set; }
            
        }
    }
}
