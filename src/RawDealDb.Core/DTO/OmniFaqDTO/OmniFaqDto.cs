using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO.OmniFaqDTO
{
    public class OmniFaqDto
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }
        //[JsonProperty("content")]
        //public List<ContentDto> Content { get; set; }
    }
}
