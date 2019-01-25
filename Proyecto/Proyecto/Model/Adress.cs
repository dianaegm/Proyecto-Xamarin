using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Proyecto.Model
{
    public class Adress
    {
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }
        [JsonProperty(PropertyName = "suite")]
        public string Suite { get; set; }
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }
        [JsonProperty(PropertyName = "zipcode")]
        public string Zipcode { get; set; }
        [JsonProperty(PropertyName = "geo")]
        public Geo Geo { get; set; }
    }
}
