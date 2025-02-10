using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Patient_Management
{
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // Abstract class defining common patient properties
    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;
        private List<string> medicalHistory = new List<string>(); // Encapsulated medical history

        public Patient(int patientId, string name, int age)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
        }

        public int PatientId { get { return patientId; } }
        public string Name { get { return name; } }
        public int Age { get { return age; } }

        // Encapsulated method to handle medical records
        protected void AddMedicalRecord(string record)
        {
            medicalHistory.Add(record);
        }

        protected void DisplayMedicalRecords()
        {
            Console.WriteLine($"Medical Records for {Name}:");
            foreach (var record in medicalHistory)
            {
                Console.WriteLine($"- {record}");
            }
        }

        // Abstract method for calculating the bill
        public abstract double CalculateBill();

        // Concrete method to get patient details
        public virtual void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
        }
    }

    // InPatient subclass implementing IMedicalRecord
    class InPatient : Patient, IMedicalRecord
    {
        private int daysAdmitted;
        private double dailyCharge;
        private double treatmentCost;

        public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge, double treatmentCost)
            : base(patientId, name, age)
        {
            this.daysAdmitted = daysAdmitted;
            this.dailyCharge = dailyCharge;
            this.treatmentCost = treatmentCost;
        }

        public override double CalculateBill()
        {
            return (daysAdmitted * dailyCharge) + treatmentCost;
        }

        public void AddRecord(string record)
        {
            AddMedicalRecord(record);
            Console.WriteLine($"Medical record added for {Name}.");
        }

        public void ViewRecords()
        {
            DisplayMedicalRecords();
        }
    }

    // OutPatient subclass implementing IMedicalRecord
    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee;
        private double medicineCost;

        public OutPatient(int patientId, string name, int age, double consultationFee, double medicineCost)
            : base(patientId, name, age)
        {
            this.consultationFee = consultationFee;
            this.medicineCost = medicineCost;
        }

        public override double CalculateBill()
        {
            return consultationFee + medicineCost;
        }

        public void AddRecord(string record)
        {
            AddMedicalRecord(record);
            Console.WriteLine($"Medical record added for {Name}.");
        }

        public void ViewRecords()
        {
            DisplayMedicalRecords();
        }
    }
}

