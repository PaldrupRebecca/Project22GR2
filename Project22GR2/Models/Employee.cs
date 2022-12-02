using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    public class Employee : Member
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public int AccessLevel { get; set; }


        public Employee(int id, string name, string address, string email) : base(id, name, address, email)
        {
        }
        public Employee()
        {

        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                Member other = (Member)obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }

        }

    }
}
