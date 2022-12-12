using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Events
{
    public class JoinEventModel : PageModel
    {
        private IEventRepository _eventRepository;
        private LoginService _loginService;
        private IJoinEventRepository _joinEventRepository;
        public Member Member { get; set; }
        public Event Event { get; set; }

        public SelectList EventNames { get; set; }

        [BindProperty]
        public JoinEvent JoinEvent { get; set; }


        public JoinEventModel(IEventRepository eventRepo, LoginService loginService, IJoinEventRepository joinEventRepository)
        {
            _joinEventRepository = joinEventRepository;
            _eventRepository = eventRepo;
            _loginService = loginService;
            List<Event> Events = _eventRepository.GetAllEvents();
            EventNames = new SelectList(Events, "Id", "Name");
        }
        public void OnGet(int id)
        {
            Member = _loginService.GetLoggedMember();
            Event = _eventRepository.GetEvent(id);

        }

        public IActionResult OnPost()
        {
            JoinEvent.MemberId = _loginService.GetLoggedMember().Id;
            _joinEventRepository.AddJoinEvent(JoinEvent);
            return RedirectToPage("Index");
        }
    }
}
