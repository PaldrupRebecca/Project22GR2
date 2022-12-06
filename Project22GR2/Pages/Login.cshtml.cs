using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Services;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages
{
    // Luca
    // AS OF THIS CURRENT BUILD, ONLY EMPLOYEES CAN LOG IN

    public class LoginModel : PageModel
    {
        private IEmployeeRepository repo;

        [BindProperty]
        public Employee Employee { get; set; }

        public LoginModel(IEmployeeRepository faemRepo)
        {
            repo = faemRepo;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            // Make a new employee, this is purposefully empty
            Employee placeholderE = new Employee();

            // Looks for email in database
            foreach (Employee e in repo.GetAllEmployees())
            {
                if (e.Email == Employee.Email)
                {
                    placeholderE = e;
                    break;
                }
            }

            // Checks password
            if (placeholderE.Password == Employee.Password)
            {
                // Success
                return RedirectToPage("Index");
            }
            else
                // No dice
                return Page();
        }
    }
}
