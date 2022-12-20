using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using Project22GR2.Services;

namespace Project22GR2.Pages.Boats
{
    public class BookingsModel : PageModel
    {
        private IBookingRepository _bookingRepository;

        private LoginService _loginService;

        public List<Booking> Bookings {get; private set;}

        public Booking Booking {get; set;}

        public BookingsModel(IBookingRepository bookingRepository, LoginService loginService)
        {
            _bookingRepository = bookingRepository;
            _loginService = loginService;
        }

        public IActionResult OnGet()
        {
            if (_loginService.GetLoggedMember() == null)
                return RedirectToPage("/Members/Login");
            else
            {
                Bookings = _bookingRepository.FilterBooking(_loginService.GetLoggedMember().Id);
                return Page();
            }
        }
        public void OnPost()
        {

        }
    }
}
