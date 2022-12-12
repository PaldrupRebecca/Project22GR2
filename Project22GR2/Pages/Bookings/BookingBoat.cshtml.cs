using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using System.Diagnostics.Metrics;

namespace Project22GR2.Pages.Bookings
{
    public class BookingBoatModel : PageModel
    {
        private IBookingRepository repo;
        public Booking Booking { get; set; }

        public BookingBoatModel(IBookingRepository conRepo)
        {
            repo = conRepo;
        }

        public void OnGet(int id)
        {
            Booking = repo.GetBooking(id);
        }
    }
}
