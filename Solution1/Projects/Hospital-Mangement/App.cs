using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Hospital_Mangement
{
    public class App
    {
        public static void Run()
        {
            Patient patient1 = new Patient("mhamed abdeelsalam", "male", 25, 101);
            Patient patient2 = new Patient("ahmed mohamed", "male", 35, 111);
            Patient patient3 = new Patient("amira mohamed", "female", 30, 121);

            Doctor doc1 = new Doctor("mohamed abdo", 40, 333, "heart");
            Doctor doc2 = new Doctor("ahmed abo el3la", 50, 345, "chest");
            Doctor doc3 = new Doctor("folan elfolany", 55, 336, "pones");
            
            
            // Adding Docotors To list.
            Doctor.AddDoctors(doc1);
            Doctor.AddDoctors(doc2);
            Doctor.AddDoctors(doc3);

            // Adding patients To list.
            Patient.AddNewPatient(patient1);
            Patient.AddNewPatient(patient2);
            Patient.AddNewPatient(patient3);


           Appointments appoinment = new Appointments();
            appoinment.SchedualAppointment(333, 101, new DateOnly(2024, 12, 12));

            Patient.SearchForPatient(101);



        }

    }
}
