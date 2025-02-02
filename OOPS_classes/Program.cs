using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    internal class Program
    {

        static void Switchcases()
        {

            Console.WriteLine("Enter which question you want to run (1 to 13):");
            int ques = Convert.ToInt32(Console.ReadLine());

            switch (ques)
            {
                case 1:
                    // Get book details from user
                    Books userBook = BookInput.GetBookDetails();

                    // Display the entered book details (Renamed method)
                    userBook.GetBookDisplay();
                    break;
                case 2:
                    // Using default constructor
                    Circle defaultCircle = new Circle();
                    Console.WriteLine("Default Circle:");
                    defaultCircle.Display();

                    // Taking user input using the GetUserRadius method
                    double userRadius = Circle.GetUserRadius();

                    // Using parameterized constructor
                    Circle userCircle = new Circle(userRadius);
                    Console.WriteLine("\nUser Defined Circle:");
                    userCircle.Display();
                    break;
                case 3:
                    // Taking user input using the GetPersonDetails method
                    Person person1 = Person.GetPersonDetails();
                    Console.WriteLine("\nOriginal Person:");
                    person1.Display();

                    // Creating a second person using the copy constructor
                    Person person2 = new Person(person1);
                    Console.WriteLine("\nCloned Person:");
                    person2.Display();
                    break;

                case 4:
                    // Taking user input for booking using the GetBookingDetails method
                    HotelBooking booking1 = HotelBooking.GetBookingDetails();
                    Console.WriteLine("\nOriginal Booking:");
                    booking1.DisplayBookingDetails();

                    // Creating a copy of the booking using the copy constructor
                    HotelBooking booking2 = new HotelBooking(booking1);
                    Console.WriteLine("\nCloned Booking:");
                    booking2.DisplayBookingDetails();

                    // Creating a default booking using the default constructor
                    HotelBooking booking3 = new HotelBooking();
                    Console.WriteLine("\nDefault Booking:");
                    booking3.DisplayBookingDetails();
                    break;

                case 5:
                    // Create a new library book object directly inside the Main method
                    LibraryBook book1 = new LibraryBook("1984", "George Orwell", 8.99);

                    // Display book details
                    book1.DisplayBookDetails();

                    // Borrow the book
                    book1.BorrowBook();

                    // Display the book details again after borrowing
                    book1.DisplayBookDetails();

                    // Return the book
                    book1.ReturnBook();

                    // Display the book details after returning
                    book1.DisplayBookDetails();
                    break;

                case 6:
                    // Create a CarRental object using the parameterized constructor
                    CarRental rental1 = new CarRental("John Doe", "Tesla Model 3", 5, 75.0);

                    // Display the rental details
                    rental1.DisplayRentalDetails();

                    // Create a CarRental object using the default constructor
                    CarRental rental2 = new CarRental();

                    // Display the rental details
                    rental2.DisplayRentalDetails();
                    break;

                case 7:
                    // Get input for Product 1
                    Console.WriteLine("Enter details for Product 1:");
                    Product product1 = Product.GetProductInput();

                    // Get input for Product 2
                    Console.WriteLine("\nEnter details for Product 2:");
                    Product product2 = Product.GetProductInput();

                    // Display individual product details
                    Product.DisplayProductOutput(product1);
                    Product.DisplayProductOutput(product2);

                    // Display the total number of products created
                    Console.WriteLine("\nTotal Number of Products Created:");
                    Product.DisplayTotalProducts();
                    break;

                case 8:
                    // Creating course objects
                    Design_Course course1 = new Design_Course("Web Development", "3 months", 500);
                    Design_Course course2 = new Design_Course("Data Science", "6 months", 800);

                    // Display initial course details
                    Console.WriteLine("Initial Course Details:");
                    course1.DisplayCourseDetails();
                    course2.DisplayCourseDetails();

                    // Update Institute name using class method
                    Console.WriteLine("\nUpdating Institute Name...");
                    Design_Course.UpdateInstituteName("Tech Academy");

                    // Display course details after updating institute name
                    Console.WriteLine("\nCourse Details after Institute Name Update:");
                    course1.DisplayCourseDetails();
                    course2.DisplayCourseDetails();
                    break;

                case 9:

                    // Creating vehicle objects
                    Vehicle vehicle1 = new Vehicle("John Doe", "Car");
                    Vehicle vehicle2 = new Vehicle("Jane Smith", "Motorcycle");

                    // Display initial vehicle details
                    Console.WriteLine("Initial Vehicle Details:");
                    vehicle1.DisplayVehicleDetails();
                    vehicle2.DisplayVehicleDetails();

                    // Update Registration Fee using class method
                    Console.WriteLine("\nUpdating Registration Fee...");
                    Vehicle.UpdateRegistrationFee(150.0);

                    // Display vehicle details after updating registration fee
                    Console.WriteLine("\nVehicle Details after Registration Fee Update:");
                    vehicle1.DisplayVehicleDetails();
                    vehicle2.DisplayVehicleDetails();
                    break;

                case 10:
                    // Creating a Student object
                    Student student1 = new Student(101, "John Doe", 8.5);
                    student1.DisplayStudentDetails();

                    // Modifying the CGPA using public method
                    student1.SetCGPA(9.0);
                    Console.WriteLine("\nAfter updating CGPA:");
                    student1.DisplayStudentDetails();

                    // Creating a PostgraduateStudent object
                    PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Alice Smith", 9.5);
                    pgStudent.DisplayPostgraduateDetails();
                    break;

                case 11:
                    // Creating a Book_Library object
                    Book_Library book2 = new Book_Library("978-3-16-148410-0", "C# Programming", "John Smith");
                    book2.DisplayBookDetails();

                    // Modifying the author using the SetAuthor method
                    book2.SetAuthor("Jane Doe");
                    Console.WriteLine("\nAfter updating author:");
                    book2.DisplayBookDetails();

                    // Creating an EBook object
                    EBook ebook1 = new EBook("978-0-262-03384-8", "Machine Learning", "Tom Mitchell", 5.6);
                    ebook1.DisplayEBookDetails();
                    break;

                case 12:
                    // Creating a BankAccount object
                    BankAccount bankAccount1 = new BankAccount("123456789", "Alice Green", 1500.75m);
                    bankAccount1.DisplayAccountDetails();

                    // Modifying the balance using the SetBalance method
                    bankAccount1.SetBalance(2000.50m);
                    Console.WriteLine("\nAfter updating balance:");
                    bankAccount1.DisplayAccountDetails();

                    // Creating a SavingsAccount object
                    SavingsAccount savingsAccount1 = new SavingsAccount("987654321", "Bob Brown", 5000.25m);
                    savingsAccount1.DisplaySavingsAccountDetails();
                    break;

                case 13:
                    // Creating an Employee object
                    Employee emp1 = new Employee(101, "IT", 50000);
                    emp1.DisplayEmployeeDetails();

                    // Modifying salary using the SetSalary method
                    emp1.SetSalary(55000);
                    Console.WriteLine("\nAfter updating salary:");
                    emp1.DisplayEmployeeDetails();

                    // Creating a Manager object
                    Manager mgr1 = new Manager(201, "HR", 70000);
                    mgr1.DisplayManagerDetails();
                    break;


                default:
                    Console.WriteLine("Invalid question number. Please select between 1 and 3.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Switchcases();
        }
    }
}

