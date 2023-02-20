using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO.OmniFaqDTO
{
    public class OmniFaqDto
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("version")]
        public string Version { get; set; }
        [JsonPropertyName("lastUpdate")]
        public string LastUpdate { get; set; }
        [JsonPropertyName("content")]
        public List<ContentDto> Content { get; set; }
    }
}
