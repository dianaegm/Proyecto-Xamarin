using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Proyecto.Model
{
    public class Geo
    {
        [JsonProperty(PropertyName = "lat")]
        public string Lat { get; set; }
        [JsonProperty(PropertyName = "lng")]
        public string Lng { get; set; }
    }
}
