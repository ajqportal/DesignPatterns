using DesignPattern.Structural.Adapter.Interfaces;
using System.Xml.Serialization;

namespace DesignPattern.Structural.Adapter.Adapters
{
    internal class XmlDataAdapter : IDataAdapter
    {
        public string ConvertData(object data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(data.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, data);
                return textWriter.ToString();
            }
        }
    }
}
