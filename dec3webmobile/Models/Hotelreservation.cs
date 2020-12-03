using System;
using System.Collections.Generic;

namespace dec3webmobile.Models
{
    public partial class Hotelreservation
    {
        public string Uid { get; set; }
        public string ReservationId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal? Price { get; set; }
        public int? NoOfRooms { get; set; }
        public string RoomType { get; set; }
        public int? NoOfTravellers { get; set; }
        public string HotelName { get; set; }
    }
}
