using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Project22GR2.Models
{
    public class Boat
    {

        [Required]
        [Range(typeof(int), "1", "1000", ErrorMessage = "Error. ID is outside of the interval.")]
        public int Id { get; set; }

        public string Type { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public string Sail { get; set; }

        public Boat()
        {

        }

    }
}
