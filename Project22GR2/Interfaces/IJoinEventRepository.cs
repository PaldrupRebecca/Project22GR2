using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    public interface IJoinEventRepository
    {
        List<JoinEvent> GetAllJoinEvents();
        JoinEvent GetJoinEvent(int id);
        void AddJoinEvent(JoinEvent joinEvent);
        void UpdateJoinEvent(JoinEvent joinEvent);
        void DeleteJoinEvent(int id);
        List<JoinEvent> FilterJoinEvents(string filter);
    }
}
