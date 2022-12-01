using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Members
{
    public class CreateMemberModel : PageModel
    {
        private IMemberRepository repo;

        [BindProperty]
        public Member Member { get; set; }

        public CreateMemberModel(IMemberRepository memberRepository)
        {
            repo = memberRepository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddMember(Member);
            return RedirectToPage("Index");
        }
    }
}
