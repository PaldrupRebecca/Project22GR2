using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project22GR2.Models;
using Project22GR2.Interfaces;
using Project22GR2.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project22GR2.Pages.Boats
{
    public class BookingModel : PageModel
    {
        private IBoatRepository _boatRepository;
        private LoginService _loginService;
        private IBookingRepository _bookingRepository;

        public Member Member { get; set; }
        [BindProperty]

        public Boat Boat { get; set; }

        public SelectList BoatTypes { get; set; }
        
        [BindProperty]
        public Booking Booking { get; set; }

        public BookingModel(IBoatRepository boatRepository, LoginService loginService, IBookingRepository bookingRepository)
        {
            _boatRepository = boatRepository;
            _loginService = loginService;
            _bookingRepository = bookingRepository;
            List<Boat> Boats = _boatRepository.GetAllBoats();
            BoatTypes = new SelectList(Boats, "Id", "Type");
        }

        public void OnGet(int id)
        {
            Member = _loginService.GetLoggedMember();
            Boat = _boatRepository.GetBoat(id);
        }

        public IActionResult OnPost()
        {
            Booking.MemberId = _loginService.GetLoggedMember().Id;
            Booking.BoatId = Boat.Id;
            Booking.MemberName = _loginService.GetLoggedMember().Name;
            Booking.BoatType = Boat.Type;
            _bookingRepository.AddBooking(Booking);
            return RedirectToPage("Index");
        }
    }
}
