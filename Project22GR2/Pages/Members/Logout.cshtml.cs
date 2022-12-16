using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Shared
{
    public class LogoutModel : PageModel
    {

        private IMemberRepository memberRepository;
        private LoginService loginService;

        public LogoutModel(IMemberRepository memRepo, LoginService login)
        {
            memberRepository = memRepo;
            loginService = login;

        }

        public IActionResult OnGet()
        {
            //List<Member> list = new List<Member>();
            //list = JsonFileReader.ReadJsonMembers(@"Data\JsonCurrentMember.json");
            //list[0].Logout();
            loginService.MemberLogOut();
            return RedirectToPage("/Index");
        }
    }
}
