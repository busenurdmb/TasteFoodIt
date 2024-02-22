using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entity
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Time { get; set; }
        public byte GuestCount { get; set; }
        public string ReservationStatus { get; set; }

        //c#-> byte sql->tinyint
    }
}