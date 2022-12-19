using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    public class Booking
    {        
        [Required]
        public int Id { get; set; }

        [Required]
        public int BoatId { get; set; }
        
        public string BoatType { get; set; }
        [Required]
        public int MemberId { get; set; }

        public string MemberName { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        //public Booking(int id, int boatId, int memberId, DateTime dateTime)
        //{
        //    Id = id;
        //    BoatId = boatId;
        //    MemberId = memberId;
        //    DateTime = dateTime;
        //}

        //public Booking()
        //{

        //}
    }
}
