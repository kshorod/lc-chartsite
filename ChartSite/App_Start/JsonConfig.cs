using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ChartSite
{
    public class JsonConfig
    {
        public static void Configure()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }
    }
}