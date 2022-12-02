using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Employees
{
    public class DeleteEmployeeModel : PageModel
    {
        private IEmployeeRepository _repo;

        [BindProperty]
        public Employee Employee { get; set; }
        public DeleteEmployeeModel(IEmployeeRepository faemRepo)
        {
            _repo = faemRepo;
        }
        public void OnGet(int id)
        {
            Employee = _repo.GetEmployee(id);
        }

        public IActionResult OnPost()
        {
            _repo.DeleteEmployee(Employee.Id);
            return RedirectToPage("Index");
        }
    }
}
