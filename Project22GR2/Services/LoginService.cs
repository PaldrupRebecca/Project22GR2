using Project22GR2.Models;

namespace Project22GR2.Services
{
    public class LoginService
    {
        private Member _loggedInMember;

        public void MemberLogin(Member member)
        {
            _loggedInMember = member;
        }
        public void MemberLogOut()
        {
            _loggedInMember = null;
        }
        public Member GetLoggedMember()
        {
            return _loggedInMember;
        }
        public bool IsLoggedMemberAdmin()
        {
            if (_loggedInMember == null)
                return false;
            else
                return _loggedInMember.IsAdmin;
        }
    }
}
