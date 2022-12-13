using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RawDealDb.Core.Models
{
    [Serializable]
    public class CardPropertyModel
    {
        [XmlAttribute("name")]
        public string? Property { get; set; }
        [XmlAttribute("value")]
        public string? Value { get; set; }
    }
}
