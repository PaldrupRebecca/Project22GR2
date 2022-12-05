using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    //Rebecca
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);
        void AddEvent(Event ev);
        void UpdateEvent(Event ev);
        void DeleteEvent(int id);
        List<Event> FilterEvents(string filter);
    }
}
