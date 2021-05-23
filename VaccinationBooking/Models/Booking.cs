using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VaccinationBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int status { get; set; }
        public AccountInfos AccountInfo { get; set; }
        public Vaccine Vaccine { get; set; }
    }
}