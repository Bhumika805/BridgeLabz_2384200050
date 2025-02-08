using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Base Class: Course
    class Course
    {
        public string CourseName { get; set; }
        public int Duration { get; set; } // Duration in weeks

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} weeks");
        }
    }

    // Subclass: OnlineCourse (Inherits from Course)
    class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Platform: {Platform}");
            Console.WriteLine($"Recorded: {(IsRecorded ? "Yes" : "No")}");
        }
    }

    // Subclass: PaidOnlineCourse (Inherits from OnlineCourse)
    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee { get; set; }
        public double Discount { get; set; } // Percentage discount

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            double finalPrice = Fee - (Fee * (Discount / 100));
            Console.WriteLine($"Fee: ${Fee}");
            Console.WriteLine($"Discount: {Discount}%");
            Console.WriteLine($"Final Price After Discount: ${finalPrice}");
        }
    }
}

