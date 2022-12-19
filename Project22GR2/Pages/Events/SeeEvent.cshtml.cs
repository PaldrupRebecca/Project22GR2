using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Events
{
    public class SeeEventModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public Event Event { get; set; }
        [BindProperty]
        public JoinEvent JoinEvent { get; set; }

        public SeeEventModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }

        public void OnGet(int id)
        {
            Event = _repo.GetEvent(id);
        }

        public void OnPost()
        {
        }
    }
}
