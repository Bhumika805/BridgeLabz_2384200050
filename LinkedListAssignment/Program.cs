using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    internal class Program
    {

        public static void SwitchCases()
        {
            Console.WriteLine("Enter Which question do you want to execute from 1 to 9");
            int ques = Convert.ToInt32(Console.ReadLine());

            switch (ques)
            {
                case 1:
                    StudentList studentList = new StudentList();
                    studentList.AddStudentAtEnd(1, "Aashutosh", 20, 'A');
                    studentList.AddStudentAtBeginning(2, "Bhumika", 21, 'B');
                    studentList.AddStudentAtPosition(3, "Ankit", 22, 'C', 2);

                    Console.WriteLine("Student Records:");
                    studentList.DisplayAllStudents();

                    Console.WriteLine("\nSearching for student with Roll Number 2:");
                    studentList.SearchStudent(2);

                    Console.WriteLine("\nUpdating grade for Roll Number 3:");
                    studentList.UpdateGrade(3, 'A');
                    studentList.DisplayAllStudents();

                    Console.WriteLine("\nDeleting student with Roll Number 1:");
                    studentList.DeleteStudent(1);
                    studentList.DisplayAllStudents();
                    break;
                case 2:
                    MovieList movieList = new MovieList();
                    movieList.AddMovieAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
                    movieList.AddMovieAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
                    movieList.AddMovieAtPosition("The Matrix", "Lana Wachowski", 1999, 8.7, 1);

                    Console.WriteLine("Movies in Forward Order:");
                    movieList.DisplayMoviesForward();

                    Console.WriteLine("\nMovies in Reverse Order:");
                    movieList.DisplayMoviesReverse();

                    Console.WriteLine("\nUpdating rating of Inception to 9.0");
                    movieList.UpdateRating("Inception", 9.0);

                    Console.WriteLine("\nSearching for movies directed by Christopher Nolan:");
                    movieList.SearchByDirectorOrRating("Christopher Nolan", 0);

                    Console.WriteLine("\nRemoving 'The Matrix' from the list");
                    movieList.RemoveMovie("The Matrix");

                    Console.WriteLine("\nFinal Movie List:");
                    movieList.DisplayMoviesForward();
                    break;
                case 3:
                    TaskScheduler scheduler = new TaskScheduler();
                    scheduler.AddAtEnd(1, "Task A", 2, DateTime.Now.AddDays(1));
                    scheduler.AddAtBeginning(2, "Task B", 1, DateTime.Now.AddDays(2));
                    scheduler.AddAtEnd(3, "Task C", 3, DateTime.Now.AddDays(3));

                    Console.WriteLine("All Tasks:");
                    scheduler.DisplayTasks();

                    Console.WriteLine("\nViewing Current Task:");
                    scheduler.ViewCurrentTask();

                    Console.WriteLine("\nSearching for tasks with Priority 2:");
                    scheduler.SearchByPriority(2);

                    Console.WriteLine("\nRemoving Task with ID 2");
                    scheduler.RemoveTask(2);
                    scheduler.DisplayTasks();
                    break;
                case 4:
                    InventoryManagementSystem inventory = new InventoryManagementSystem();
                    inventory.AddAtEnd(1, "Item A", 10, 5.5);
                    inventory.AddAtBeginning(2, "Item B", 5, 10.0);
                    inventory.AddAtEnd(3, "Item C", 8, 7.5);

                    Console.WriteLine("All Items:");
                    inventory.DisplayItems();

                    Console.WriteLine("\nUpdating Quantity of Item ID 2 to 12");
                    inventory.UpdateQuantity(2, 12);
                    inventory.DisplayItems();

                    Console.WriteLine("\nSearching for Item ID 3:");
                    inventory.SearchItem(3);

                    Console.WriteLine("\nCalculating Total Inventory Value:");
                    inventory.CalculateTotalValue();

                    Console.WriteLine("\nRemoving Item ID 1");
                    inventory.RemoveItem(1);
                    inventory.DisplayItems();
                    break;
                case 5:
                    LibraryManagementSystem library = new LibraryManagementSystem();
                    library.AddAtEnd(1, "Book A", "Author X", "Fiction", true);
                    library.AddAtBeginning(2, "Book B", "Author Y", "Sci-Fi", false);
                    library.AddAtEnd(3, "Book C", "Author Z", "History", true);

                    Console.WriteLine("All Books (Forward Order):");
                    library.DisplayBooksForward();

                    Console.WriteLine("\nUpdating Availability of Book ID 2 to Available");
                    library.UpdateAvailability(2, true);
                    library.DisplayBooksForward();

                    Console.WriteLine("\nSearching for Book 'Book C':");
                    library.SearchBook("Book C");

                    Console.WriteLine("\nTotal Number of Books: " + library.CountBooks());

                    Console.WriteLine("\nRemoving Book ID 1");
                    library.RemoveBook(1);
                    library.DisplayBooksForward();
                    break;
                case 6:
                    RoundRobinSchedulingAlgorithm scheduler2 = new RoundRobinSchedulingAlgorithm();
                    scheduler2.AddProcess(1, 10, 1);
                    scheduler2.AddProcess(2, 5, 2);
                    scheduler2.AddProcess(3, 8, 1);
                    scheduler2.AddProcess(4, 12, 3);

                    Console.WriteLine("Initial Process Queue:");
                    scheduler2.DisplayProcesses();

                    Console.WriteLine("\nStarting Round Robin Scheduling with Time Quantum = 4");
                    scheduler2.RoundRobinScheduling(4);
                    break;
                case 7:
                    SocialMediaFriendConnections socialNetwork = new SocialMediaFriendConnections();
                    socialNetwork.AddUser(1, "Ankit", 25);
                    socialNetwork.AddUser(2, "Bhumika", 27);
                    socialNetwork.AddUser(3, "Aashutosh", 23);
                    socialNetwork.AddUser(4, "Dev", 30);

                    socialNetwork.AddFriend(1, 2);
                    socialNetwork.AddFriend(1, 3);
                    socialNetwork.AddFriend(2, 3);
                    socialNetwork.AddFriend(3, 4);

                    Console.WriteLine("Friend Lists:");
                    socialNetwork.DisplayFriends(1);
                    socialNetwork.DisplayFriends(2);
                    socialNetwork.DisplayFriends(3);
                    socialNetwork.DisplayFriends(4);

                    Console.WriteLine("\nFinding Mutual Friends:");
                    socialNetwork.FindMutualFriends(1, 3);
                    socialNetwork.FindMutualFriends(2, 4);

                    Console.WriteLine("\nFriend Counts:");
                    socialNetwork.CountFriends();
                    break;
                case 8:
                    Undo_RedoFunctionalityforTextEditor textEditor = new Undo_RedoFunctionalityforTextEditor();
                    textEditor.AddState("Hello");
                    textEditor.AddState("Hello, World");
                    textEditor.AddState("Hello, World!");

                    textEditor.DisplayCurrentState();
                    textEditor.Undo();
                    textEditor.Undo();
                    textEditor.Redo();
                    break;
                case 9:
                    OnlineTicketReservationSystem ticketSystem = new OnlineTicketReservationSystem();
                    ticketSystem.AddTicket(1, "Alice", "Inception", "A1");
                    ticketSystem.AddTicket(2, "Bob", "Interstellar", "B2");
                    ticketSystem.AddTicket(3, "Charlie", "Dunkirk", "C3");

                    Console.WriteLine("\nAll Booked Tickets:");
                    ticketSystem.DisplayTickets();

                    Console.WriteLine("\nSearch for tickets by movie name 'Interstellar':");
                    ticketSystem.SearchTicket("Interstellar");

                    Console.WriteLine("\nTotal Tickets: " + ticketSystem.TotalTickets());

                    Console.WriteLine("\nRemoving Ticket ID 2:");
                    ticketSystem.RemoveTicket(2);

                    Console.WriteLine("\nUpdated Ticket List:");
                    ticketSystem.DisplayTickets();
                    break;
                default:
                    Console.WriteLine("Input is Invalid");
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitchCases();
        }
    }
}
