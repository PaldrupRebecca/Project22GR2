using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Events
{
    //Rebecca
    public class EditEventModel : PageModel
    {

        private IEventRepository _repo;

        [BindProperty]
        public Event Event { get; set; }

        public EditEventModel(IEventRepository eventRepository)
        {
            _repo = eventRepository;
        }

        public void OnGet(int id)
        {
            Event = _repo.GetEvent(id);
        }

        public IActionResult OnPostEdit()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.UpdateEvent(Event);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repo.DeleteEvent(Event.Id);
            return RedirectToPage("Index");
        }
    }
}
