using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Boats
{
    public class CreateBoatModel : PageModel
    {
        private IBoatRepository repo;
        private LoginService _loginService;

        [BindProperty]
        public Boat Boat { get; set; }

        public CreateBoatModel(IBoatRepository faboRepo, LoginService loginService)
        {
            repo = faboRepo;
            _loginService = loginService;
        }
        public IActionResult OnGet()
        {
            if (_loginService.GetLoggedMember() == null)
                return RedirectToPage("/Members/Login");
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.AddBoat(Boat);
            return RedirectToPage("Index");
        }
    }
}
