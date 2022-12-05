using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Employees
{
    public class CreateEmployeeModel : PageModel
    {
        private IEmployeeRepository repo;

        [BindProperty]
        public Employee Employee { get; set; }

        public CreateEmployeeModel(IEmployeeRepository faemRepo)
        {
            repo = faemRepo;
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
            repo.AddEmployee(Employee);
            return RedirectToPage("Index");
        }
    }
}
