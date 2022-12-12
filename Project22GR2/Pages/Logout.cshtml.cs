using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Models;
using Project22GR2.Helpers;

namespace Project22GR2.Pages.Shared
{
    public class LogoutModel : PageModel
    {

        [BindProperty]
        public Member Member { get; set; }

        public LogoutModel()
        {

        }

        public IActionResult OnGet()
        {
            List<Member> list = new List<Member>();
            list = JsonFileReader.ReadJsonMembers(@"Data\JsonCurrentMember.json");
            list[0].Logout();
            return RedirectToPage("Index");
        }
    }
}
