using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Events
{
    //Rebecca
    public class DeleteEventModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public Event Event { get; set; }

        public DeleteEventModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }

        public void OnGet(int id)
        {
            Event = _repo.GetEvent(id);
        }

        public IActionResult OnPost()
        {
            _repo.DeleteEvent(Event.Id);
            return RedirectToPage("Index");
        }
    }
}
