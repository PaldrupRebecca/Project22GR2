using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Events
{
    public class JoinedEventsModel : PageModel
    {
        private IJoinEventRepository _jRepo;

        [BindProperty]
        public string FilterCriteria { get; set; }
        public List<JoinEvent> JoinEvents { get; private set; }

        public JoinedEventsModel(IJoinEventRepository joinEventRepository)
        {
            _jRepo = joinEventRepository;
        }
        public void OnGet()
        {
            JoinEvents = _jRepo.GetAllJoinEvents();
        }

        public void OnPost()
        {
            
        }
    }
}
