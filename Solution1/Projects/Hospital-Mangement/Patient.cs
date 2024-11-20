using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Hospital_Mangement
{
    public class Patient : Person
    {

        public List<string> MedicalHistory = new List<string>();
        public static List<Patient> patients = new List<Patient>();

        //Default Constructor 
        public Patient() { }

        // Parametrise Constructor Accepts name, gender, age, id 
        public Patient(string name,string gender,int age,int id)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.ID = id;
        }
        //Adding new patient
        public static void AddNewPatient(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine($"{patient.Name} has Been Added.");
        }


        // Adding new medical history
        public void AddNewMedicalHistory(string medicalHistory)
        {
            MedicalHistory.Add(medicalHistory); 
        }
        
        // Displaying Medical History 
        public void DisplayMedicalHistory()
        {
            Console.WriteLine("Medical History : ");
            foreach(var medicalHistory in MedicalHistory)
            {
                Console.WriteLine(medicalHistory);
            }
        }


        // Searching for a patient and dipalying all of his inforamarion
        public static void SearchForPatient(int patientId)
        {
            Patient patient = new Patient();

            foreach(var  pat in patients)
            {
                if(pat.ID== patientId)
                    patient = pat;
            }

            Console.WriteLine("Patient's Details :   ");
            Console.WriteLine($"Name : {patient.Name}");
            Console.WriteLine($"ID : {patient.ID}");
            Console.WriteLine($"Age : {patient.Age}");
            Console.WriteLine($"Gender : {patient.Gender}");
            Console.WriteLine($"Medical History : ");
            foreach(var medHistory in patient.MedicalHistory)
            {
                Console.WriteLine(medHistory);
            }
        }
    }
}
