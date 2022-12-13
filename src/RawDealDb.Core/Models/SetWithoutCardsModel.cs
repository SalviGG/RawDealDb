using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RawDealDb.Core.Models
{
    [Serializable]
    public class SetWithoutCardsModel
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("id")]
        public Guid Id { get; set; }
    }
}
