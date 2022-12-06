using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Services;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages
{
    // Luca
    // AS OF THIS CURRENT BUILD, MEMBERS CAN LOG IN

    public class LoginModel : PageModel
    {
        private IMemberRepository repo;

        [BindProperty]
        public Member Member { get; set; }

        public LoginModel(IMemberRepository fameRepo)
        {
            repo = fameRepo;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            // Make a new Member, this is purposefully empty
            Member placeholderM = new Member();

            // Looks for email in database
            foreach (Member m in repo.GetAllMembers())
            {
                if (m.Email == Member.Email)
                {
                    placeholderM = m;
                    break;
                }
            }

            // Checks password
            if (placeholderM.Password == Member.Password)
            {
                // Success
                return RedirectToPage("Index");
            }
            else
                // No dice
                return Page();
        }
    }
}
