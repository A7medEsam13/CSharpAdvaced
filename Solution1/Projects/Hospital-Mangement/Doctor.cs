using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Hospital_Mangement
{
    public class Doctor : Person
    {
        public string Speciality {  get; set; }
        public static List<Doctor> Doctors = new List<Doctor>();

        public List<Appointments> Appointments = new List<Appointments>();

        // viewing upcoming Appointments
        public void ViewUpcomingAppointments()
        {
            Console.WriteLine("Upcoming Appointments : ");
            foreach (var appointment in Appointments)
            {
                Console.WriteLine($"- {appointment}");
            }
        }

        public Doctor() { }


        // Parametrise Constructor Accepts name, age, id, speciality
        public Doctor(string name,int age,int id ,string spciality)
        {
            this.Speciality = spciality;
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }


        // Adding new Doctor
        public static void AddDoctors(Doctor doctor)
        {
            Doctors.Add(doctor);
            Console.WriteLine($"{doctor.Name} has added!");
        }

    }
}
