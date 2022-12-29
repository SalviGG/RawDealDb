using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawDealDb.Core.DTO
{
    public class ChangeLogDto
    {
        public string Version { get; set; }
        public string Date { get; set; }
        public List<string> Added { get; set; }
        public List<string> Changed { get; set; }
        public List<string> Fixed { get; set; }
    }
}
