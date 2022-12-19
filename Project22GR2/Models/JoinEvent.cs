namespace Project22GR2.Models
{
    public class JoinEvent
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

    }
}
