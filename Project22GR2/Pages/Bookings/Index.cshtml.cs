using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using System.Diagnostics.Metrics;

namespace Project22GR2.Pages.Bookings
{
    public class BookingIndexModel : PageModel
    {
        private IBookingRepository _repo;
        public string FilterCriteria { get; set; }

        [BindProperty]
        public List<Booking> Bookings { get; set; }

        public BookingIndexModel(IBookingRepository conRepo)
        {
            _repo = conRepo;
        }
        public void OnGet()
        {
            Bookings = _repo.GetAllBookings();
        }


    }
}
