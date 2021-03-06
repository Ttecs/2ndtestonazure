﻿using System;
using System.Collections.Generic;

namespace dec3webmobile.Models
{
    public partial class Eventreservation
    {
        public string Uid { get; set; }
        public string ReservationId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public decimal? Price { get; set; }
        public string Eventtype { get; set; }
    }
}
