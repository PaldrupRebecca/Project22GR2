using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Members
{
    public class IndexModel : PageModel
    {
        private IMemberRepository _repo;

        [BindProperty]
        public string FilterCriteria { get; set; }
        public List<Member> Members { get; private set; }

        public IndexModel(IMemberRepository memberRepository)
        {
            _repo = memberRepository;
        }
        public void OnGet()
        {
            Members = _repo.GetAllMembers();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Members = _repo.FilterMember(FilterCriteria);
            else
                Members = _repo.GetAllMembers();
        }
    }
}
