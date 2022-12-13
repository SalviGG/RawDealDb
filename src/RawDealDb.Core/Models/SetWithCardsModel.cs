using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RawDealDb.Core.Models
{
    [Serializable]
    public class SetWithCardsModel
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("id")]
        public Guid Id { get; set; }
        [XmlArray("cards")]
        [XmlArrayItem("card", typeof(CardModel))]
        public List<CardModel> Cards { get; set; }
    }
}
