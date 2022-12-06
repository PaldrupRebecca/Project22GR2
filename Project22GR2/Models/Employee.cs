using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    public class Employee : Member
    {
        [Required]
        public int AccessLevel { get; set; }


        public Employee(string password, int id, string name, string address, string email, int accessLevel, bool isAdmin) : base(password, id, name, address, email, isAdmin)
        {
            AccessLevel = accessLevel;
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
