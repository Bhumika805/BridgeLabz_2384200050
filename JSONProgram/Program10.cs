using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JSONProgram
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    class Program10
    {
        static void Main()
        {
            string filePath = "users.json"; // Path to JSON file

            // Read JSON file
            string jsonString = File.ReadAllText(filePath);

            // Deserialize JSON array to List<User>
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);

            // Filter users older than 25
            var filteredUsers = users.Where(u => u.Age > 25).ToList();

            // Print filtered users
            foreach (var user in filteredUsers)
            {
                Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, Email: {user.Email}");
            }
        }
    }


}
