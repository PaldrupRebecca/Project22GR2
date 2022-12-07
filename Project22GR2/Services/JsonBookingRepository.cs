using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using System.Diagnostics.Metrics;

namespace Project22GR2.Services
{
    public class JsonBookingRepository : IBookingRepository
    {
        string filePath = @"Data\JsonBookings.json";

        public void AddBooking(Booking booking)
        {
            List<Booking> bookings = GetAllBookings();
            bookings.Add(booking);
            JsonFileWriter.WriteToJsonBookings(bookings, filePath);
        }

        public void DeleteBooking(int id)
        {
            Booking BookingToDelete = GetBooking(id);
            List<Booking> bookings = GetAllBookings();
            bookings.Remove(BookingToDelete);
            JsonFileWriter.WriteToJsonBookings(bookings, filePath);
        }

        public List<Booking> FilterBooking(string filter)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetAllBookings()
        {
            return JsonFileReader.ReadJsonBookings(filePath);
        }

        public Booking GetBooking(int id)
        {
            List<Booking> bookings = GetAllBookings();
            foreach (Booking b in bookings)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }
            return new Booking();
        }

        public void UpdateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
