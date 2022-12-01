using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Boats
{
    public class EditBoatModel : PageModel
    {
        private IBoatRepository repo;

        [BindProperty]
        public Boat Boat { get; set; }

        public EditBoatModel(IBoatRepository faboRepo)
        {
            repo = faboRepo;
        }

        public void OnGet(int id)
        {
            Boat = repo.GetBoat(id);
        }

        public IActionResult OnPost()
        {
            repo.UpdateBoat(Boat);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            repo.DeleteBoat(Boat.Id);
            return RedirectToPage("Index");
        }
    }
}
