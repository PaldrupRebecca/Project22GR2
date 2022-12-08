using Project22GR2.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Project22GR2.Models
{
    
    //Lavet af Adam
    public class Member
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public Member(string password, int id, string name, string address, string email, bool isAdmin)
        {
            Password = password;
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            IsAdmin = isAdmin;
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

        // Luca
        public void Login(Member member)
        { 
            List<Member> list = new List<Member>();
            list.Add(member);
            JsonFileWriter.WritetoJsonMembers(list, @"Data\JsonCurrentMember.json");
        }

        public void Logout()
        {
            List<Member> test = new List<Member>();
            JsonFileWriter.WritetoJsonMembers(test, @"Data\JsonCurrentMember.json");
        }

    }
}
