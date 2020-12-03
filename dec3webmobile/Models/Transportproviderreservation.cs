using System;
using System.Collections.Generic;

namespace dec3webmobile.Models
{
    public partial class Transportproviderreservation
    {
        public string Uid { get; set; }
        public string ReservationId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal? Price { get; set; }
        public string VehicleType { get; set; }
        public string PickupLocation { get; set; }
        public TimeSpan? PickupTime { get; set; }
        public string DropOffLocation { get; set; }
        public int? NumOfTravellers { get; set; }
    }
}
