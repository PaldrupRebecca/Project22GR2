using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Members
{
    public class LoginModel : PageModel
    {
        private IMemberRepository memberRepository;
        private LoginService loginService;
        public string AccessDenied = "";
        [BindProperty]
        public Member Member { get; set; }

        public LoginModel(IMemberRepository memRepo, LoginService login)
        {
            memberRepository = memRepo;
            loginService = login;

        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            foreach (Member member in memberRepository.GetAllMembers())
            {
                if (member.Email == Member.Email && member.Password==Member.Password)
                {
                    loginService.MemberLogin(member);
                    return RedirectToPage("/Index");
                }
                AccessDenied = "Email or password is incorrect";
            }
            return Page();
        }
    }
}
