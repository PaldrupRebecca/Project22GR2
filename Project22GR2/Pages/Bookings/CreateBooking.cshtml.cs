using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Models;
using Project22GR2.Interfaces;
using System.Diagnostics.Metrics;

namespace Project22GR2.Pages.Bookings
{
    public class CreateBookingModel : PageModel
    {
        private IBookingRepository repo;

        [BindProperty]
        public Booking Booking { get; set; }

        public CreateBookingModel(IBookingRepository bookingRepository)
        {
            repo = bookingRepository;
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
            repo.AddBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
