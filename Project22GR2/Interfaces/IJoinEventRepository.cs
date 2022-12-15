using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    public interface IJoinEventRepository
    {
        List<JoinEvent> GetAllJoinEvents();
        void AddJoinEvent(JoinEvent joinEvent);
        JoinEvent GetJoinEventById(int id);
        List<JoinEvent> GetJoinEventByMemberId(int memberId);
        void DeleteJoinEvent(JoinEvent joinEvent);
        List<JoinEvent> FilterJoinEvents(int memberId);
    }
}
