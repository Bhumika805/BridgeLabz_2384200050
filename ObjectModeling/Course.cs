using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModeling
{
        internal class Course
        {
            private string courseName;
            private List<Student> students;  // Many-to-Many Relationship

            // Constructor
            public Course(string courseName)
            {
                this.courseName = courseName;
                this.students = new List<Student>();
            }

            // Getter for Course Name
            public string GetCourseName() => courseName;

            // Add Student to the Course
            public void EnrollStudent(Student student)
            {
                students.Add(student);
            }

            // Display Enrolled Students
            public void ShowEnrolledStudents()
            {
                Console.WriteLine($"Students in {courseName}:");
                if (students.Count == 0)
                {
                    Console.WriteLine("No students enrolled.");
                    return;
                }

                foreach (var student in students)
                {
                    Console.WriteLine($"- {student.GetStudentName()}");
                }
            }
        }

        // Student Class (Association: A Student enrolls in multiple courses)
        class Student
        {
            private string studentName;
            private List<Course> courses;  // Many-to-Many Relationship

            // Constructor
            public Student(string studentName)
            {
                this.studentName = studentName;
                this.courses = new List<Course>();
            }

            // Getter for Student Name
            public string GetStudentName() => studentName;

            // Enroll in a Course
            public void EnrollInCourse(Course course)
            {
                courses.Add(course);
                course.EnrollStudent(this);  // Adding student to course (Bidirectional Association)
            }

            // Display Courses Enrolled
            public void ShowCourses()
            {
                Console.WriteLine($"{studentName} is enrolled in:");
                if (courses.Count == 0)
                {
                    Console.WriteLine("No courses enrolled.");
                    return;
                }

                foreach (var course in courses)
                {
                    Console.WriteLine($"- {course.GetCourseName()}");
                }
            }
        }

        // School Class (Aggregation: A School has multiple Students)
        class School
        {
            private string schoolName;
            private List<Student> students;  // Aggregation: School has Students

            // Constructor
            public School(string schoolName)
            {
                this.schoolName = schoolName;
                this.students = new List<Student>();
            }

            // Getter for School Name
            public string GetSchoolName() => schoolName;

            // Add Student to School
            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            // Display Students in the School
            public void ShowStudents()
            {
                Console.WriteLine($"Students in {schoolName}:");
                if (students.Count == 0)
                {
                    Console.WriteLine("No students in school.");
                    return;
                }

                foreach (var student in students)
                {
                    Console.WriteLine($"- {student.GetStudentName()}");
                }
            }
        }

        class Management
        {
            static void Main()
            {
                // Creating a School
                School mySchool = new School("Global High School");

                // Creating Students
                Student student1 = new Student("Alice");
                Student student2 = new Student("Bob");

                // Adding Students to School (Aggregation)
                mySchool.AddStudent(student1);
                mySchool.AddStudent(student2);

                // Creating Courses
                Course math = new Course("Mathematics");
                Course science = new Course("Science");

                // Enrolling Students in Courses (Association)
                student1.EnrollInCourse(math);
                student1.EnrollInCourse(science);
                student2.EnrollInCourse(math);

                // Displaying School Students
                mySchool.ShowStudents();

                // Displaying Student Courses
                student1.ShowCourses();
                student2.ShowCourses();

                // Displaying Enrolled Students in Courses
                math.ShowEnrolledStudents();
                science.ShowEnrolledStudents();
            }
        }
    }


