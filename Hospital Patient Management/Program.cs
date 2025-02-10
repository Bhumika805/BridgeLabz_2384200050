using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Patient_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "John Doe", 45, 5, 2000, 5000),
            new OutPatient(102, "Jane Smith", 30, 500, 1000)
        };

            Console.WriteLine("Hospital Patient Details and Billing:\n");

            foreach (var patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Total Bill: {patient.CalculateBill():C}\n");
            }

            // Managing medical records
            Console.WriteLine("Adding Medical Records:\n");
            foreach (var patient in patients)
            {
                if (patient is IMedicalRecord medicalRecord)
                {
                    medicalRecord.AddRecord("Routine check-up performed.");
                    medicalRecord.AddRecord("Prescribed medication.");
                }
            }

            Console.WriteLine("\nViewing Medical Records:\n");
            foreach (var patient in patients)
            {
                if (patient is IMedicalRecord medicalRecord)
                {
                    medicalRecord.ViewRecords();
                    Console.WriteLine();
                }
            }
        }
    }
}
