using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    
    //Lavet af Adam
    public class Member
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        public Member(int id, string name, string address, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
        }

        public Member()
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
