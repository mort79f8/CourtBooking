using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using CourtBooking.Entities;
using Newtonsoft.Json;

namespace CourtBooking.Service
{
    public class BookingService
    {
        public string Url { get; set; }

        public List<Booking> GetListOfData()
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(Url);
                List<Booking> bookings = JsonConvert.DeserializeObject<List<Booking>>(json);
                return bookings;
            }
        }

        public Booking GetSingleBooking(int id)
        {
            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(Url +"/" + id);
                Booking booking = JsonConvert.DeserializeObject<Booking>(json);
                return booking;
            }
        }
    }
}
