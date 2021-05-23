using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaccinationBooking.Models
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Dosage { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}