using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Boats
{
    public class CreateBoatModel : PageModel
    {
        private IBoatRepository repo;

        [BindProperty]
        public Boat Boat { get; set; }

        public CreateBoatModel(IBoatRepository faboRepo)
        {
            repo = faboRepo;
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
            repo.AddBoat(Boat);
            return RedirectToPage("Index");
        }
    }
}
