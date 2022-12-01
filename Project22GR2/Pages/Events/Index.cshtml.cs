using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Events
{
    //Rebecca
    public class IndexModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public string FilterCriteria { get; set; }
        public List<Event> Events { get; private set; }

        public IndexModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }
        public void OnGet()
        {
            Events = _repo.GetAllEvents();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Events = _repo.FilterEvents(FilterCriteria);
            else
                Events = _repo.GetAllEvents();
        }
    }
}
