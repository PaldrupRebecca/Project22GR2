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
            List<JoinEvent> joinEvents = GetAllJoinEvents();
            joinEvents.Add(joinEvent);
            JsonFileWriter.WriteToJsonJoinEvents(joinEvents, jsonFileName);
        }

        public void DeleteJoinEvent(int id)
        {
            JoinEvent joinEventToDelete = GetJoinEvent(id);
            List<JoinEvent> joinEvents = GetAllJoinEvents();
            joinEvents.Remove(joinEventToDelete);
            JsonFileWriter.WriteToJsonJoinEvents(joinEvents, jsonFileName);
        }

        public List<JoinEvent> FilterJoinEvents(string filter)
        {
            throw new NotImplementedException();
        }

        public List<JoinEvent> GetAllJoinEvents()
        {
            return JsonFileReader.ReadJsonJoinEvents(jsonFileName);
        }

        public JoinEvent GetJoinEvent(int id)
        {
            List<JoinEvent> joinEvents = GetAllJoinEvents();
            foreach (JoinEvent item in joinEvents)
            {
                if (item.Id == id)
                    return item;
            }
            return new JoinEvent();
        }

        public void UpdateJoinEvent(JoinEvent joinEvent)
        {
            if (joinEvent != null)
            {
                List<JoinEvent> joinEvents = GetAllJoinEvents();
                foreach (JoinEvent je in joinEvents)
                {
                    if (je.Id == joinEvent.Id)
                    {
                        je.Id = joinEvent.Id;
                        je.MemberId = joinEvent.MemberId;
                        je.EventId = je.EventId;
                    }
                }
                JsonFileWriter.WriteToJsonJoinEvents(joinEvents, jsonFileName);
            }
        }
    }
}
