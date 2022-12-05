using Microsoft.AspNetCore.Mvc;
using Project22GR2.Models;
using Project22GR2.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project22GR2.Pages.Members
{
    public class DeleteMemberModel : PageModel
    {
        private IMemberRepository repo;

        [BindProperty]

        public Member Member { get; set; }
        public DeleteMemberModel(IMemberRepository memberRepo)
        {
            repo = memberRepo;
        }
        public void OnGet(int id)
        {
            Member = repo.GetMember(id);
        }

        public IActionResult OnPost()
        {
            repo.DeleteMember(Member.Id);
            return RedirectToPage("Index");
        }
    }
}
