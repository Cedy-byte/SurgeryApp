using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurgeryApp
{
    class Appointment
    {
        public DateTime ApptTime{ get; set; }
        public DateTime BookingTIme { get; set; }
        public Patient Patient { get; set; }

        public Appointment(DateTime apptTime, DateTime bookingTIme, Patient patient)
        {
            ApptTime = apptTime;
            BookingTIme = bookingTIme;
            Patient = patient;
        }
    }
}
