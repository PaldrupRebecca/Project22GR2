using Project22GR2.Models;
using System.Text.Json;

namespace RazorPagesEventMakerInClass22.Helpers
{
    public class JsonFileReader
    {
        public static List<Boat> ReadJsonBoats(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Boat>>(indata);
            }
        }

        // Also add Reader for Event, Member, etc
    }

}
