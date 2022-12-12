using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Models;

namespace Project22GR2.Pages.Members
{
    public class LoginModel : PageModel
    {
        public Member Member { get; set; }

        public LoginModel(Member member)
        {
            Member = member;
        }
        public void OnGet()
        {
        }

        //public IActionResult OnPost()
        //{ 
            
        //}
    }
}
