using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Services
{
    public class JsonMemberRepository : IMemberRepository
    {

        string jsonFileName = @"Data\JsonMembers.json";
        public void AddMember(Member members)
        {
            List<Member> member = GetAllMembers();
            member.Add(members);
            JsonFileWriter.WritetoJsonMembers(member, jsonFileName);
        }

        public void DeleteMember(int id)
        {
            Member memberToDelete = GetMember(id);
            List<Member> member = GetAllMembers();
            member.Remove(memberToDelete);
            JsonFileWriter.WritetoJsonMembers(member, jsonFileName);
        }

        public List<Member> FilterMember(string filter)
        {
            List<Member> filteredList = new List<Member>();
            foreach (var item in GetAllMembers())
            {
                if (item.Name.Contains(filter) || item.Address.Contains(filter))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        public List<Member> GetAllMembers()
        {
            return JsonFileReader.ReadJsonMembers(jsonFileName);
        }

        public Member GetMember(int id)
        {
            List<Member> members = GetAllMembers();
            foreach (Member m in members)
            {
                if (m.Id == id)
                    return m;
            }
            return new Member();
        }

        public void UpdateMember(Member members)
        {
            if (members != null)
            {
                List<Member> member = GetAllMembers();
                foreach (Member m in member)
                {
                    if (m.Id == members.Id)
                    {
                        m.Id = members.Id;
                        m.Name = members.Name;
                        m.Address = members.Address;
                        m.Email = members.Email;
                    }
                }
                JsonFileWriter.WritetoJsonMembers(member, jsonFileName);
            }
        }
    }
}
