using Project22GR2.Helpers;
using Project22GR2.Interfaces;
using Project22GR2.Models;
using System.Diagnostics.Metrics;

namespace Project22GR2.Services
{
    public class JsonBookingRepository : IBookingRepository
    {
        string jsonFileName = @"Data\JsonBookings.json";

        public void AddBooking(Booking booking)
        {
            List<Booking> bookings = GetAllBookings();
            List<int> ids = new List<int>();

            foreach (var b in bookings)
            {
                ids.Add(b.Id);
            }
            if (ids.Count != 0)
            {
                int start = ids.Max();
                booking.Id = start + 1;
            }
            else
            {
                booking.Id = 1;
            }
            JsonFileWriter.WriteToJsonBookings(bookings, jsonFileName);
        }

        public void DeleteBooking(int id)
        {
            Booking BookingToDelete = GetBooking(id);
            List<Booking> bookings = GetAllBookings();
            bookings.Remove(BookingToDelete);
            JsonFileWriter.WriteToJsonBookings(bookings, jsonFileName);
        }

        public List<Booking> FilterBooking(int memberId)
        {
            List<Booking> filteredList = new List<Booking>();
            foreach (var item in GetAllBookings())
            {
                if (item.MemberId == memberId)
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }



        public List<Booking> GetAllBookings()
        {
            return JsonFileReader.ReadJsonBookings(jsonFileName);
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
    }
}
