using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class PatientTriageSystem
        {
            public class Patient
            {
                public string Name { get; }
                public int Severity { get; }

                public Patient(string name, int severity)
                {
                    Name = name;
                    Severity = severity;
                }
            }

            public static void SimulateTriage()
            {
                // Using a SortedDictionary to simulate a priority queue
                SortedDictionary<int, Queue<Patient>> queue = new SortedDictionary<int, Queue<Patient>>();

                void EnqueuePatient(Patient patient)
                {
                    int priority = -patient.Severity; // Higher severity should come first (negate to sort correctly)

                    if (!queue.ContainsKey(priority))
                        queue[priority] = new Queue<Patient>();

                    queue[priority].Enqueue(patient);
                }

                Patient DequeuePatient()
                {
                    if (queue.Count == 0) return null;

                    int highestPriority = GetFirstKey(queue); // Get the highest priority key correctly
                    Queue<Patient> patients = queue[highestPriority];

                    Patient patient = patients.Dequeue();
                    if (patients.Count == 0) queue.Remove(highestPriority);

                    return patient;
                }

                // Function to get the first key in SortedDictionary
                int GetFirstKey(SortedDictionary<int, Queue<Patient>> dict)
                {
                    foreach (var key in dict.Keys) return key;
                    return 0; // This should never happen since we check queue.Count before calling
                }

                // Adding patients
                EnqueuePatient(new Patient("John", 3));
                EnqueuePatient(new Patient("Alice", 5));
                EnqueuePatient(new Patient("Bob", 2));

                Console.WriteLine("Treatment Order:");
                while (queue.Count > 0)
                {
                    Patient patient = DequeuePatient();
                    Console.WriteLine(patient.Name);
                }
            }

            public void DisplayPatientTriage()
            {
                 new PatientTriageSystem().DisplayPatientTriage();
            }
        
    }
}
