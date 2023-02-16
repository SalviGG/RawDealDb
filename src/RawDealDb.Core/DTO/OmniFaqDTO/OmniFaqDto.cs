using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO.OmniFaqDTO
{
    public class OmniFaqDto
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string LastUpdate { get; set; }
        public List<ContentDto> Content { get; set; }
    }
}
