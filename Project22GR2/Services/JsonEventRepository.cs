using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Services
{
    //Rebecca
    public class JsonEventRepository : IEventRepository
    {
        string jsonFileName = @"Data\JsonEvents.json";
        public void AddEvent(Event ev)
        {
            List<Event> events = GetAllEvents();
            events.Add(ev);
            JsonFileWriter.WritetoJsonEvents(events, jsonFileName);
        }

        public void DeleteEvent(int id)
        {
            Event eventToDelete = GetEvent(id);
            List<Event> events = GetAllEvents();
            events.Remove(eventToDelete);
            JsonFileWriter.WritetoJsonEvents(events, jsonFileName);
        }

        public List<Event> FilterEvents(string filter)
        {
            List<Event> filteredList = new List<Event>();
            foreach (var item in GetAllEvents())
            {
                if (item.Name.Contains(filter) || item.Description.Contains(filter))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJsonEvents(jsonFileName);
        }

        public Event GetEvent(int id)
        {
            List<Event> events = GetAllEvents();
            foreach (Event item in events)
            {
                if (item.Id == id)
                    return item;
            }
            return new Event();
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                List<Event> events = GetAllEvents();
                foreach (Event e in events)
                {
                    if (e.Id == ev.Id)
                    {
                        e.Id = ev.Id;
                        e.Name = ev.Name;
                        e.Description = ev.Description;
                        e.DateTime = ev.DateTime;
                        e.Price = ev.Price;
                    }
                }
                JsonFileWriter.WritetoJsonEvents(events, jsonFileName);
            }
        }
    }
}
