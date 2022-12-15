using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Events
{
    public class JoinedEventsModel : PageModel
    {
        private IJoinEventRepository _jRepo;

        //[BindProperty]
        //public int MemberId { get; set; }
        private LoginService _loginService;
        public List<JoinEvent> JoinEvents { get; private set; }
        public JoinEvent JoinEvent { get; set; }

        public JoinedEventsModel(IJoinEventRepository joinEventRepository, LoginService loginservice)
        {
            _jRepo = joinEventRepository;
            _loginService = loginservice;
        }
        public void OnGet()
        {
            JoinEvents = _jRepo.FilterJoinEvents(_loginService.GetLoggedMember().Id);
        }

        public void OnPost()
        {
            
        }
    }
}
