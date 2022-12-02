namespace Project22GR2.Models
{
    public class Booking
    {
        //Rebecca
        public int Id { get; set; }
        public Boat Boat { get; set; }
        public Member Member { get; set; }
        public DateTime DateTime { get; set; }
    }
}
