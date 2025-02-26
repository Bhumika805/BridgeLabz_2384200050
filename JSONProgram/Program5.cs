using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONProgram
{
    class Program5
    {
        static void Main()
        {
            // Define JSON schema
            string schemaJson = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'email': { 'type': 'string', 'format': 'email' },
                'age': { 'type': 'integer', 'minimum': 18 }
            },
            'required': ['name', 'email']
        }";

            // Define JSON data
            string jsonString = @"{
            'name': 'John Doe',
            'email': 'john.doe@example.com',
            'age': 25
        }";

            // Parse JSON schema and data
            JSchema schema = JSchema.Parse(schemaJson);
            JObject jsonData = JObject.Parse(jsonString);

            // Validate JSON
            if (jsonData.IsValid(schema, out IList<string> validationErrors))
            {
                Console.WriteLine("JSON is valid!");
            }
            else
            {
                Console.WriteLine("JSON is invalid:");
                foreach (var error in validationErrors)
                {
                    Console.WriteLine($"- {error}");
                }
            }
        }
    }


}
