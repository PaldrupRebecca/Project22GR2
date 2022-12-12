using Project22GR2.Models;

namespace Project22GR2.Interfaces
{
    //Adam
    public interface IBookingRepository
    {
        List<Booking> GetAllBookings();
        Booking GetBooking(int id);

        void AddBooking(Booking booking);

        void UpdateBooking(Booking booking);

        void DeleteBooking(int id);

        List<Booking> FilterBooking(string filter);
    }
}
