using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Services
{
    public class JsonJoinEventRepository : IJoinEventRepository
    {
        string jsonFileName = @"Data\JsonJoinEvents.json";

        public void AddJoinEvent(JoinEvent joinEvent)
        {
            List<JoinEvent> joinEvents = GetAllJoinEvents();
            List<int> joinsIds = new List<int>();

            foreach (var b in joinEvents)
            {
                joinsIds.Add(b.Id);
            }
            if (joinsIds.Count != 0)
            {
                int start = joinsIds.Max();
                joinEvent.Id = start + 1;
            }
            else
            {
                joinEvent.Id = 1;
            }
            joinEvents.Add(joinEvent);
            JsonFileWriter.WriteToJsonJoinEvents(joinEvents, jsonFileName);
        }

        public void DeleteJoinEvent(JoinEvent joinEvent)
        {

        }

        public List<JoinEvent> GetAllJoinEvents()
        {
            return JsonFileReader.ReadJsonJoinEvents(jsonFileName);
        }

        public JoinEvent GetJoinEventById(int id)
        {
            List<JoinEvent> joinEvents = GetAllJoinEvents();
            foreach (JoinEvent j in joinEvents)
            {
                if (j.Id == id)
                    return j;
            }
            return new JoinEvent();
        }

        public List<JoinEvent> GetJoinEventByMemberId(int memberId)
        {
            throw new NotImplementedException();
        }

        public List<JoinEvent> FilterJoinEvents(int memberId)
        {
            List<JoinEvent> filteredList = new List<JoinEvent>();
            foreach (var item in GetAllJoinEvents())
            {
                if (item.MemberId == memberId)
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
    }
}
