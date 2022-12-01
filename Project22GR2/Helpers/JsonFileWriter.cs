using Project22GR2.Models;
using System.Text.Json;

namespace Project22GR2.Helpers
{
    public class JsonFileWriter
    {
        public static void WritetoJsonBoats(List<Boat> boats, string jsonFileName)
        {
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Boat[]>(writer, boats.ToArray());
            }
        }

        
        //Adam
        public static void WritetoJsonMembers(List<Member> members, string jsonFileName)
        {
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writer = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Member[]>(writer, members.ToArray());
            }
        }

        //Rebecca
        public static void WritetoJsonEvents(List<Event> events, string jsonFileName)
        {
            //using(FileStream outputStream =File.OpenWrite(jsonFileName))
            using (FileStream outputStream = File.Create(jsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Event[]>(writter, events.ToArray());
            }
        }
    }

}
