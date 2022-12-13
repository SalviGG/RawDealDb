using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RawDealDb.Tools
{
    public static class XMLParser
    {
        public static T SerializeXml<T>(string rootElement, string[] xmlFile) where T : class
        {
            var root = new XmlRootAttribute()
            {
                ElementName= rootElement,
                IsNullable= true
            };
            var serializer = new XmlSerializer(typeof(T), root);
            using(var reader = new StreamReader(xmlFile[0]))
            {
                var desObject = (T)serializer.Deserialize(reader);
                return desObject;
            }
        }
    }
}
