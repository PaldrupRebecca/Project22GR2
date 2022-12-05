using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    //Adam
    public interface IMemberRepository
    {
        List<Member> GetAllMembers();
        Member GetMember(int id);

        void AddMember(Member members);

        void UpdateMember(Member members);

        void DeleteMember(int id);

        List<Member> FilterMember(string filter);

    }
}
