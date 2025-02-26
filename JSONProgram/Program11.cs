using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONProgram
{
    class Program11
    {
        static void Main()
        {
            // Define JSON schema with email validation
            string schemaJson = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'email': { 'type': 'string', 'format': 'email' }
            },
            'required': ['name', 'email']
        }";

            // Example JSON data
            string jsonString = @"{
            'name': 'John Doe',
            'email': 'john.doe@example.com'
        }";

            // Parse schema and JSON data
            JSchema schema = JSchema.Parse(schemaJson);
            JObject jsonData = JObject.Parse(jsonString);

            // Validate JSON against schema
            if (jsonData.IsValid(schema, out IList<string> validationErrors))
            {
                Console.WriteLine(" JSON is valid!");
            }
            else
            {
                Console.WriteLine(" JSON is invalid:");
                foreach (var error in validationErrors)
                {
                    Console.WriteLine($"- {error}");
                }
            }
        }
    }


}
