using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Boats
{
    public class IndexModel : PageModel
    {
        private IBoatRepository _repo;

        [BindProperty]
        public string FilterCriteria { get; set; }
        public List<Boat> Boats { get; private set; }
        public IndexModel(IBoatRepository repo)
        {
            _repo = repo;
        }


        public void OnGet()
        {
            Boats = _repo.GetAllBoats();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Boats = _repo.FilterBoats(FilterCriteria);
            else
                Boats = _repo.GetAllBoats();
        }


    }
}
