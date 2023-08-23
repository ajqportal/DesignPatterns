using DesignPattern.Structural.Adapter.Interfaces;
using Newtonsoft.Json;

namespace DesignPattern.Structural.Adapter.Adapters
{
    internal class JsonDataAdapter : IDataAdapter
    {
        public string ConvertData(object data)
        {
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }
    }
}
