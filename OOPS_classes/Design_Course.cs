using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class Design_Course
    {
        // Instance Variables
        private string courseName;
        private string duration;
        private double fee;

        // Class Variable (Shared among all courses)
        private static string instituteName = "Default Institute"; // Default value for all courses

        // Constructor to initialize course details
        public Design_Course(string courseName, string duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // Instance Method: DisplayCourseDetails
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"\nCourse Name: {courseName}");
            Console.WriteLine($"Duration: {duration}");
            Console.WriteLine($"Fee: ${fee}");
            Console.WriteLine($"Institute Name: {instituteName}");
        }

        // Class Method: UpdateInstituteName (Static method to update the institute name)
        public static void UpdateInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName; // Modify the class variable
            Console.WriteLine($"\nInstitute name has been updated to: {instituteName}");
        }
    }
}
