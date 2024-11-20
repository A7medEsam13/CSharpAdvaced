using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Hospital_Mangement
{
    public class Appointments
    {
        Patient patient =new Patient();
        Doctor doctor = new Doctor();
        DateOnly AppointmentDate {  get; set; }
        List<Appointments> appointments = new List<Appointments>();

        // adding a new appointment
        public void SchedualAppointment(int DoctorID, int PatientID,DateOnly appointmentDate)
        {
            Appointments appoinment = new Appointments();
            appoinment.AppointmentDate = appointmentDate;
            
            foreach(var Doctor in Doctor.Doctors)
            {
                if(Doctor.ID == DoctorID)
                    appoinment.doctor = Doctor;
                doctor.Appointments.Add(appoinment);
                Console.WriteLine($"A new appointment Added to doctor {Doctor.Name}");
            }
            foreach(var patient in Patient.patients)
            {
                if(patient.ID== PatientID)
                    appoinment.patient = patient;
                patient.MedicalHistory.Add(appointmentDate.ToString());
                Console.WriteLine($"A new appointment Added to patient {patient.Name}");
            }

            appointments.Add(appoinment);
            Console.WriteLine("A new Appointment is added!");
        }


        // Displaying all Appointments
        public void DisplayAllAppointments()
        {
            foreach(var appointment in appointments)
            {
                Console.WriteLine("\tAppointment Details :");
                Console.WriteLine($"Appointment's Patient : {appointment.patient.Name}");
                Console.WriteLine($"appointment's Doctor : {appointment.doctor.Name}");
                Console.WriteLine($"Appointment's Date : {appointment.AppointmentDate}");
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
