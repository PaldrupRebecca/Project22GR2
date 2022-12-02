using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private IEmployeeRepository _repo;

        [BindProperty]
        public string FilterCriteria { get; set; }
        public List<Employee> Employees { get; private set; }
        public IndexModel(IEmployeeRepository repo)
        {
            _repo = repo;
        }


        public void OnGet()
        {
            Employees = _repo.GetAllEmployees();
        }

        public void OnPost()
        {
            if (FilterCriteria != null)
                Employees = _repo.FilterEmployee(FilterCriteria);
            else
                Employees = _repo.GetAllEmployees();
        }
    }
}
