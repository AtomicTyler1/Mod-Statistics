using System.Reflection;
using System.Text.Json;

namespace ModStatistics.Platforms
{
    public static class Thunderstore
    {
        public static Dictionary<string, ThunderstoreJSONContent> GetThunderstoreMods()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.EndsWith("thunderstore.json"));

            if (string.IsNullOrEmpty(resourceName))
            {
                throw new FileNotFoundException("Could not find embedded thunderstore.json");
            }

            using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null) return new Dictionary<string, ThunderstoreJSONContent>();

                using (StreamReader reader = new StreamReader(stream))
                {
                    string jsonContent = reader.ReadToEnd();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    var teams = JsonSerializer.Deserialize<Dictionary<string, ThunderstoreJSONContent>>(jsonContent, options)
                               ?? new Dictionary<string, ThunderstoreJSONContent>();

                    return teams;
                }
            }
        }
    }
}