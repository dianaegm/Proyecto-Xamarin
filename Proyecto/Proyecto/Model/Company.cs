using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Proyecto.Model
{
    public class Company
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "catchPhrase")]
        public string CatchPhrase { get; set; }
        [JsonProperty(PropertyName = "bs")]
        public string Bs { get; set; }
    }
}
