using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace JSONProgram
{
    
    class Program13
    {
        static void Main()
        {
            // Example JSON string
            string jsonString = @"{
            'name': 'John Doe',
            'email': 'john@example.com',
            'age': 30,
            'address': {
                'street': '123 Main St',
                'city': 'New York'
            }
        }";

            // Convert JSON to XML
            JObject json = JObject.Parse(jsonString);
            XDocument xml = JsonConvert.DeserializeXNode(json.ToString(), "Root");

            // Print XML output
            Console.WriteLine(xml);
        }
    }


}
