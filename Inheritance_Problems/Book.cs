using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Superclass: Book
    class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }

    // Subclass: Author (Single Inheritance from Book)
    class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear, string name, string bio)
            : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Book & Author Details:");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Author: {Name}");
            Console.WriteLine($"Bio: {Bio}");
            Console.WriteLine("---------------------------");
        }
    }
}
