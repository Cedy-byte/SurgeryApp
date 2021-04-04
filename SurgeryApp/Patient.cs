using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurgeryApp
{
    class Patient
    {
        public string PatientID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Patient(string patientID, string firstName, string surname)
        {
            PatientID = patientID;
            FirstName = firstName;
            Surname = surname;
        }

        public override string ToString()
        {
            return PatientID+" : "+FirstName+" "+Surname;
        }
    }
}
