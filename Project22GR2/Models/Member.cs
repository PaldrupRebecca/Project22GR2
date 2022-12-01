namespace Project22GR2.Models
{
    public class Member
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Member(int id, string name, string address, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
        }
    }
}
