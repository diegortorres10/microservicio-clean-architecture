using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Person
    {
        [JsonProperty("person_id")]
        public int PersonId { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("gender", Required = Required.Always)]
        public string Gender { get; set; }

        [JsonProperty("age", Required = Required.Always)]
        public int Age { get; set; }

        [JsonProperty("identification", Required = Required.Always)]
        public string Identification { get; set; }

        [JsonProperty("address", Required = Required.Always)]
        public string Address { get; set; }

        [JsonProperty("phone", Required = Required.Always)]
        public string Phone { get; set; }

        public virtual Client Client { get; set; }
    }
}
