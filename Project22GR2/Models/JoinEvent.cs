namespace Project22GR2.Models
{
    public class JoinEvent
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int EventId { get; set; }

        public JoinEvent(int id, int memberId, int eventId)
        {
            Id = id;
            MemberId = memberId;
            EventId = eventId;
        }

        public JoinEvent()
        {
        }
    }
}
