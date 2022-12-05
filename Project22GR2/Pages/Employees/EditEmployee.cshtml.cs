using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Employees
{
    public class EditEmployeeModel : PageModel
    {
        private IEmployeeRepository repo;

        [BindProperty]
        public Employee Employee { get; set; }

        public EditEmployeeModel(IEmployeeRepository faemRepo)
        {
            repo = faemRepo;
        }

        public void OnGet(int id)
        {
            Employee = repo.GetEmployee(id);
        }

        public IActionResult OnPost()
        {
            repo.UpdateEmployee(Employee);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            repo.DeleteEmployee(Employee.Id);
            return RedirectToPage("Index");
        }
    }
}
