using Newtonsoft.Json;

namespace ChartSite.Data.Serialization.Helpers
{
    public static class SerializationHelpers
    {
        public static string ToJson(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}