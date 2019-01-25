using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Proyecto.Model
{
    public class Root
    {
         [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "address")]
        public Adress Address { get; set; }
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "Website")]
        public string website { get; set; }
        [JsonProperty(PropertyName = "company")]
        public Company Company { get; set; }

    }
}
