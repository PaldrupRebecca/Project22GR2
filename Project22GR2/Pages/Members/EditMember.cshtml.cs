using Microsoft.AspNetCore.Mvc;
using Project22GR2.Models;
using Project22GR2.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project22GR2.Pages.Members
{
    public class EditMemberModel : PageModel
    {
        private IMemberRepository repo;

        [BindProperty]
        public Member Member { get; set; }

        public EditMemberModel(IMemberRepository memberRepo)
        {
            repo = memberRepo;
        }

        public void OnGet(int id)
        {
            Member = repo.GetMember(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateMember(Member);
            return RedirectToPage("Index");
        }
    }
}
