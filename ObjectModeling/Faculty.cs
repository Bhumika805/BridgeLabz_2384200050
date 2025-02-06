using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModeling
{
        class Faculty
        {
            private string facultyName;

            // Constructor
            public Faculty(string facultyName)
            {
                this.facultyName = facultyName;
            }

            // Getter for Faculty Name
            public string GetFacultyName() => facultyName;
        }

        // Department Class (Composition: Belongs to University)
        class Department
        {
            private string departmentName;

            // Constructor
            public Department(string departmentName)
            {
                this.departmentName = departmentName;
            }

            // Getter for Department Name
            public string GetDepartmentName() => departmentName;
        }

        // University Class (Composition with Department, Aggregation with Faculty)
        class University
        {
            private string universityName;
            private List<Department> departments;  // Composition (Strong Relationship)
            private List<Faculty> faculties;       // Aggregation (Weak Relationship)

            // Constructor initializes university with empty lists of departments and faculties
            public University(string universityName)
            {
                this.universityName = universityName;
                this.departments = new List<Department>();
                this.faculties = new List<Faculty>();
            }

            // Add a Department (Composition)
            public void AddDepartment(string departmentName)
            {
                departments.Add(new Department(departmentName));
            }

            // Add a Faculty Member (Aggregation)
            public void AddFaculty(Faculty faculty)
            {
                faculties.Add(faculty);
            }

            // Display Departments
            public void ShowDepartments()
            {
                Console.WriteLine($"Departments in {universityName}:");
                if (departments.Count == 0)
                {
                    Console.WriteLine("No departments available.");
                    return;
                }
                foreach (var dept in departments)
                {
                    Console.WriteLine($"- {dept.GetDepartmentName()}");
                }
            }

            // Display Faculty Members
            public void ShowFaculties()
            {
                Console.WriteLine($"Faculty members in {universityName}:");
                if (faculties.Count == 0)
                {
                    Console.WriteLine("No faculty members available.");
                    return;
                }
                foreach (var faculty in faculties)
                {
                    Console.WriteLine($"- {faculty.GetFacultyName()}");
                }
            }

            // Destructor to simulate deletion of University (Composition effect)
            ~University()
            {
                Console.WriteLine($"University '{universityName}' is deleted! All departments are also deleted.");
            }
        }

        class Univ_Faculty
        {
            static void Faculty_Univ()
            {
                // Creating a University
                University myUniversity = new University("Oxford University");

                // Adding Departments (Composition: If University is deleted, Departments are too)
                myUniversity.AddDepartment("Computer Science");
                myUniversity.AddDepartment("Mechanical Engineering");

                // Creating Faculty members (Aggregation: Faculty members exist independently)
                Faculty faculty1 = new Faculty("Dr. Smith");
                Faculty faculty2 = new Faculty("Dr. Johnson");

                // Adding Faculty to the University
                myUniversity.AddFaculty(faculty1);
                myUniversity.AddFaculty(faculty2);

                // Display Departments and Faculty Members
                myUniversity.ShowDepartments();
                myUniversity.ShowFaculties();

                // Simulate University deletion
                myUniversity = null;  // University is deleted, but faculty members still exist

                // Explicitly call garbage collector (for demo purposes, not usually needed)
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // Faculties still exist
                Console.WriteLine("\nFaculty members still exist after University deletion:");
                Console.WriteLine($"- {faculty1.GetFacultyName()}");
                Console.WriteLine($"- {faculty2.GetFacultyName()}");
            }
        }
    }

