using Project22GR2.Models;
using System.Text.Json;

namespace Project22GR2.Helpers
{
    public class JsonFileReaderEvents
    {
        public static List<Event> ReadJsonEvents(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(indata);
            }
        }
    }
}
