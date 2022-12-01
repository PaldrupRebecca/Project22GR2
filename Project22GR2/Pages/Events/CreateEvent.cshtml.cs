using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Events
{
    public class CreateEventModel : PageModel
    {
        private IEventRepository _repo;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
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
            _repo.AddEvent(Event);
            return RedirectToPage("Index");
        }
    }
}
