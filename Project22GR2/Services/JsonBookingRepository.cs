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
            bookings.Add(booking);
            JsonFileWriter.WriteToJsonBookings(bookings, jsonFileName);
        }

        public void DeleteBooking(int id)
        {
            Booking BookingToDelete = GetBooking(id);
            List<Booking> bookings = GetAllBookings();
            bookings.Remove(BookingToDelete);
            JsonFileWriter.WriteToJsonBookings(bookings, jsonFileName);
        }

        public List<Booking> FilterBooking(int filter)
        {
            throw new NotImplementedException();
            //List<Booking> filteredList = new List<Booking>();
            //foreach (Booking item in GetAllBookings())
            //{
            //    if (item.BoatId = filter || item.MemberId = filter || item.DateTime = filter)
            //    {
            //        filteredList.Add(item);
            //    }
            //}
            //return filteredList;
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

        public void UpdateBooking(Booking booking)
        {
            if (booking != null)
            {
                List<Booking> bookings = GetAllBookings();
                foreach (Booking b in bookings)
                {
                    if (b.Id == booking.Id)
                    {
                        b.Id = booking.Id;
                        b.BoatId = booking.BoatId;
                        b.MemberId = booking.MemberId;
                        b.DateTime = booking.DateTime;
                    }
                }
                JsonFileWriter.WriteToJsonBookings(bookings, jsonFileName);
            }
        }
    }
}
