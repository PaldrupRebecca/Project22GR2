using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Events
{
    //Rebecca
    public class CreateEventModel : PageModel
    {
        
        private IEventRepository _repo;
        private LoginService _loginService;

        [BindProperty]
        public Event Event { get; set; }

        public CreateEventModel(IEventRepository eventRepository, LoginService loginService)
        {
            _repo = eventRepository;
            _loginService = loginService;
        }

        public IActionResult OnGet()
        {
            if (_loginService.GetLoggedMember() == null)
                return RedirectToPage("/Members/Login");
            else
            {
                return Page();
            }
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
