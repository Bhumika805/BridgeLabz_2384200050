using BusinessLayer.Interface;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class RegistrationAPIBL : IRegistrationBL
    {
        private readonly IDistributedCache _cache;
        private readonly IRegistrationRL _repository;

        public RegistrationAPIBL(IDistributedCache cache, IRegistrationRL repository)
        {
            _cache = cache;
            _repository = repository;
        }

        public string Registration(string value)
        {
            return $"Hello {value}, Welcome!";
        }

        public List<EmployeeEntity> GetAllEmployees()
        {
            string cacheKey = "EmployeeList";
            List<EmployeeEntity> employees;

            // 🔹 Logging Redis check
            Console.WriteLine($"🔍 Checking Redis for key: {cacheKey}");

            var cachedData = _cache.GetString(cacheKey);
            if (!string.IsNullOrEmpty(cachedData))
            {
                Console.WriteLine("✅ Data found in Redis. Returning cached data.");
                employees = JsonConvert.DeserializeObject<List<EmployeeEntity>>(cachedData);
                return employees;
            }

            Console.WriteLine("❌ Data not found in Redis. Fetching from database...");

            // 🔹 Fetch from database
            employees = _repository.GetAllEmployees();

            if (employees != null && employees.Count > 0)
            {
                Console.WriteLine("🟢 Storing data in Redis...");
                var cacheOptions = new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
                };

                string jsonData = JsonConvert.SerializeObject(employees);
                _cache.SetString(cacheKey, jsonData, cacheOptions);
            }
            else
            {
                Console.WriteLine("⚠️ No employees found in database.");
            }

            return employees;
        }



    }
}



