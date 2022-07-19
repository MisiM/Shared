using Newtonsoft.Json;

namespace Utils
{
    public static class HtmlConverter
    {
        public static string Serialize<T>(T value) where T : class
        {
            return JsonConvert.SerializeObject(value);
        }

        public static T Deserialize<T>(string value) where T : class
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
