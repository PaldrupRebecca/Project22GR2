using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;

namespace Project22GR2.Pages.Bookings
{
    public class EditBookingModel : PageModel
    {
        private IBookingRepository repo;

        [BindProperty]
        public Booking Booking { get; set; }

        public EditBookingModel(IBookingRepository Repo)
        {
            repo = Repo;
        }

        public void OnGet(int id)
        {
            Booking = repo.GetBooking(id);
        }

        public IActionResult OnPost()
        {
            repo.UpdateBooking(Booking);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostDelete()
        {
            repo.DeleteBooking(Booking.Id);
            return RedirectToPage("Index");
        }
    }
}
