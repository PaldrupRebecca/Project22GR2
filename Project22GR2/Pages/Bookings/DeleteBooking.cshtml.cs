using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using System.Diagnostics.Metrics;

namespace Project22GR2.Pages.Bookings
{
    public class DeleteBookingModel : PageModel
    {
        private IBookingRepository repo;
        [BindProperty]

        public Booking Booking { get; set; }
        public DeleteBookingModel(IBookingRepository bookingRepo)
        {
            repo = bookingRepo;
        }
        public void OnGet(int id)
        {
            Booking = repo.GetBooking(id);
        }

        public IActionResult OnPost()
        {
            repo.DeleteBooking(Booking.Id);
            return RedirectToPage("CountryIndex");
        }
    }
}
