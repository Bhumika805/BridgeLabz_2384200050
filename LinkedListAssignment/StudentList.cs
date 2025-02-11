using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
   
    class Student
    {
        public int RollNumber;
        public string Name;
        public int Age;
        public char Grade;
        public Student Next;

        public Student(int rollNumber, string name, int age, char grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }

    class StudentList
    {
        private Student head;

        // Adds a new student at the beginning of the list
        public void AddStudentAtBeginning(int rollNumber, string name, int age, char grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            newStudent.Next = head;
            head = newStudent;
        }

        // Adds a new student at the end of the list
        public void AddStudentAtEnd(int rollNumber, string name, int age, char grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (head == null)
            {
                head = newStudent;
                return;
            }
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
        }

        // Adds a new student at a specified position in the list
        public void AddStudentAtPosition(int rollNumber, string name, int age, char grade, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddStudentAtBeginning(rollNumber, name, age, grade);
                return;
            }
            Student newStudent = new Student(rollNumber, name, age, grade);
            Student temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }

        // Deletes a student from the list by Roll Number
        public void DeleteStudent(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            if (head.RollNumber == rollNumber)
            {
                head = head.Next;
                return;
            }
            Student temp = head, prev = null;
            while (temp != null && temp.RollNumber != rollNumber)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            prev.Next = temp.Next;
        }

        // Searches for a student by Roll Number and displays their details
        public void SearchStudent(int rollNumber)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    Console.WriteLine($"Roll Number: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");
        }

        // Updates the grade of a student by Roll Number
        public void UpdateGrade(int rollNumber, char newGrade)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");
        }

        // Displays all student records in the list
        public void DisplayAllStudents()
        {
            if (head == null)
            {
                Console.WriteLine("No students found.");
                return;
            }
            Student temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll Number: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
    }

}
