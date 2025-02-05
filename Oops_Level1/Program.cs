using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Level1
{
    internal class Program
    {
        static void SwitchCases()
        {
            Console.WriteLine("Enter Question number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AccountInfo accountInfo = new AccountInfo();
                    accountInfo.BankSystem(); // Call AccountDetails to perform operations
                    break;

                case 2:
                    Library library = new Library();
                    library.LibrarySystem();
                    break;

                case 3:
                    EmployeeSystem empSystem = new EmployeeSystem();
                    empSystem.EmployeeManagement();
                    break;

                case 4:
                    // Updating discount for all products
                    Product.UpdateDiscount(15.0);

                    // Creating product objects
                    Product product1 = new Product(101, "Ipad", 1200.00, 2);
                    Product product2 = new Product(102, "Laptop", 800.00, 5);

                    // Displaying product details
                    product1.DisplayProductDetails();
                    product2.DisplayProductDetails();

                    break;

                case 5:
                    // Display total students before enrollment
                    UniversityStudentManagement.DisplayTotalStudents();

                    // Creating student objects
                    UniversityStudentManagement student1 = new UniversityStudentManagement("Bhumika", 101, 'A');
                    UniversityStudentManagement student2 = new UniversityStudentManagement("AAshu", 102, 'B');

                    // Display total students after enrollment
                    UniversityStudentManagement.DisplayTotalStudents();

                    // Displaying student details
                    student1.DisplayStudentDetails();
                    student2.DisplayStudentDetails();

                    // Updating student grade
                    student2.UpdateGrade('A');

                    // Display updated details
                    student2.DisplayStudentDetails();
                    break;

                case 6:
                    // Updating the registration fee
                    VehicleRegistrationSystem.UpdateRegistrationFee(550.00);

                    // Creating vehicle objects
                    VehicleRegistrationSystem vehicle1 = new VehicleRegistrationSystem("Alice Johnson", "Car", "ABC123");
                    VehicleRegistrationSystem vehicle2 = new VehicleRegistrationSystem("Bob Smith", "Motorcycle", "XYZ789");

                    // Displaying vehicle details
                    vehicle1.DisplayVehicleDetails();
                    vehicle2.DisplayVehicleDetails();
                    break;

                case 7:
                    // Display total patients before admitting any
                    HospitalManagementSystem.GetTotalPatients();

                    // Creating patient objects
                    HospitalManagementSystem patient1 = new HospitalManagementSystem(101, "Bhumika", 30, "Flu");
                    HospitalManagementSystem patient2 = new HospitalManagementSystem(102, "Ashu", 45, "Fever");

                    // Display total patients after admission
                    HospitalManagementSystem.GetTotalPatients();

                    // Displaying patient details
                    patient1.DisplayPatientDetails();
                    patient2.DisplayPatientDetails();
                    break;




                default:
                    Console.WriteLine("Invalid question number. Please choose valid number.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitchCases();
        }
    }
}
