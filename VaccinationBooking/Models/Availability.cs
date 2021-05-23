using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaccinationBooking.Models
{
    public class Availability
    {
        public int Id { get; set; }
        public int OxygenBeds { get; set; }
        public int NormalBeds { get; set; }
        public int ActiveBeds { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}