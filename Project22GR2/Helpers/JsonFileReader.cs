using Project22GR2.Models;
using System.Text.Json;

namespace Project22GR2.Helpers
{
    public class JsonFileReader
    {
        // Luca
        public static List<Boat> ReadJsonBoats(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Boat>>(indata);
            }
        }


        //Adam
        public static List<Member> ReadJsonMembers(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Member>>(indata);
            }
        }


        //Rebecca
        public static List<Event> ReadJsonEvents(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Event>>(indata);
            }
        }
        // Also add Reader for Event, Member, etc
        public static List<Employee> ReadJsonEmployees(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Employee>>(indata);
            }
        }

        public static List<Booking> ReadJsonBookings(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<Booking>>(indata);
            }
        }













        // Daniel
        public static List<BlogPost> ReadJsonBlogPosts(string jsonFileName)
        {
            using (var jsonFileReader = File.OpenText(jsonFileName))
            {
                string indata = jsonFileReader.ReadToEnd();
                return JsonSerializer.Deserialize<List<BlogPost>>(indata);
            }
        }


    }
}
