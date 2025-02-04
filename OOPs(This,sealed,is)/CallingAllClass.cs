using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_This_sealed_is_
{
    internal class CallingAllClass
    {
        public void CallingLibrary()
        {
            Book.DisplayLibraryName();

            // Creating book objects
            Book book1 = new Book("C# Programming", "John Doe", "123-456-789");
            Book book2 = new Book("Data Structures", "Jane Smith", "987-654-321");

            // Displaying book details
            book1.DisplayBookDetails();
            book2.DisplayBookDetails();
        }

        public void CallingEmployee()
        {
            // Creating employee objects
            Employee emp1 = new Employee("Alice Johnson", 101, "Software Engineer");
            Employee emp2 = new Employee("Bob Smith", 102, "Project Manager");

            // Display total employees
            Employee.DisplayTotalEmployees();

            // Displaying employee details
            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
        }

        public void CallingShoppingCart()
        {
            // Updating discount for all products
            Product.UpdateDiscount(15.0);

            // Creating product objects
            Product product1 = new Product(101, "Laptop", 1200.00, 2);
            Product product2 = new Product(102, "Smartphone", 800.00, 5);

            // Displaying product details
            product1.DisplayProductDetails();
            product2.DisplayProductDetails();
        }

        public void CallingUniversity()
        {
            // Display total students before enrollment
            Student.DisplayTotalStudents();

            // Creating student objects
            Student student1 = new Student("Aashutosh", 101, 'A');
            Student student2 = new Student("Ankit", 102, 'B');

            // Display total students after enrollment
            Student.DisplayTotalStudents();

            // Displaying student details
            student1.DisplayStudentDetails();
            student2.DisplayStudentDetails();

            // Updating student grade
            student2.UpdateGrade('A');

            // Display updated details
            student2.DisplayStudentDetails();
        }

        public void CallingVehicle()
        {
            // Updating the registration fee
            Vehicle.UpdateRegistrationFee(550.00);

            // Creating vehicle objects
            Vehicle vehicle1 = new Vehicle("Alice Johnson", "Car", "ABC123");
            Vehicle vehicle2 = new Vehicle("Bob Smith", "Motorcycle", "XYZ789");

            // Displaying vehicle details
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
        }

        public void CallingHospital()
        {

            // Display total patients before admitting any
            Patient.GetTotalPatients();

            // Creating patient objects
            Patient patient1 = new Patient(101, "Aashutosh", 30, "Flu");
            Patient patient2 = new Patient(102, "Ankit", 45, "Fever");

            // Display total patients after admission
            Patient.GetTotalPatients();

            // Displaying patient details
            patient1.DisplayPatientDetails();
            patient2.DisplayPatientDetails();
        }
    }
}
