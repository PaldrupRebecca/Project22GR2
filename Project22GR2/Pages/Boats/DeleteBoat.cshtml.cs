using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Boats
{
    public class DeleteBoatModel : PageModel
    {
        private IBoatRepository _repo;

        [BindProperty]
        public Boat Boat { get; set; }
        public DeleteBoatModel(IBoatRepository faboRepo)
        {
            _repo = faboRepo;
        }
        public void OnGet(int id)
        {
            Boat = _repo.GetBoat(id);
        }

        public IActionResult OnPost()
        {
            _repo.DeleteBoat(Boat.Id);
            return RedirectToPage("Index");
        }
    }
}
