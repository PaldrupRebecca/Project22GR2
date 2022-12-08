using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Services
{
    public class JsonJoinEventRepository : IJoinEventRepository
    {
        string jsonFileName = @"Data\JsonJoinEvent.json";

        public void AddJoinEvent(JoinEvent joinEvent)
        {
            throw new NotImplementedException();
        }

        public void DeleteJoinEvent(int id)
        {
            throw new NotImplementedException();
        }

        public List<JoinEvent> FilterJoinEvents(string filter)
        {
            throw new NotImplementedException();
        }

        public List<JoinEvent> GetAllJoinEvents()
        {
            return JsonFileReader.ReadJsonJoinEvent(jsonFileName);
        }

        public JoinEvent GetJoinEvent(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateJoinEvent(JoinEvent joinEvent)
        {
            throw new NotImplementedException();
        }
    }
}
