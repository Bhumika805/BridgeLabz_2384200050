using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
     public class User
        {
            public string Username { get; set; }
            public int Age { get; set; }
        }

        class ProgramUser
        {
            static void Main()
            {
                User user = new User { Username = "JohnDoe", Age = 25 };
                string json = ConvertToJson(user);
                Console.WriteLine(json);
            }

            static string ConvertToJson(object obj)
            {
                var jsonDict = new Dictionary<string, object>();
                var properties = obj.GetType().GetProperties();

                foreach (var property in properties)
                {
                    jsonDict[property.Name] = property.GetValue(obj);
                }

            return System.Text.Json.JsonSerializer.Serialize(jsonDict, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            }
        }

    
}
