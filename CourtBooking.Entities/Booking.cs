using System;
using System.Collections.Generic;
using System.Text;

namespace CourtBooking.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int Courtnumber { get; set; }
        public DateTime BookingTime { get; set; }
        public string Booker { get; set; }

    }
}
