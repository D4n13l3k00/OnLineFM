using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OnLineFM
{
    public class FavObj
    {
        [XmlElement("Station")]
        public string Station { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Url")]
        public string Url { get; set; }
    }
    public static class SerializeExtension
    {
        public static string SerializeToString(this object obj)
        {
            var xmlSerializer = new XmlSerializer(obj.GetType());
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, obj);
            return stringWriter.ToString();
        }

        public static T DeserializeString<T>(this string sourceString)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var stringReader = new StringReader(sourceString);
            return (T)xmlSerializer.Deserialize(stringReader);
        }
    }
}
