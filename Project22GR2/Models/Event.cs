using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    //Rebecca
    public class Event
    {
        [Required(ErrorMessage = "The id of the event is required")]
        [Range(typeof(int), "1", "100000", ErrorMessage = "The chosen id is outside of the interval")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name of the event is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A description of the event is required")]
        public string Description { get; set; }
      
        [Required(ErrorMessage = "The time of the event is required")]
        [Range(typeof(DateTime), "01/12/2022", "01/01/2025", ErrorMessage = "The chosen date is outside of interval")]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "The price of the event is required")]
        [Range(typeof(double), "1", "10000", ErrorMessage = "The price is too low or too high")]
        public double Price { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Event other = (Event)obj;
                if (other.Id == Id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                    
            }
        }
    }
}
