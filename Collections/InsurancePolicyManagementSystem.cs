using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Policy : IComparable<Policy>
    {
        public string PolicyNumber { get; }
        public string CoverageType { get; }
        public DateTime ExpiryDate { get; }

        public Policy(string policyNumber, string coverageType, DateTime expiryDate)
        {
            PolicyNumber = policyNumber;
            CoverageType = coverageType;
            ExpiryDate = expiryDate;
        }

        // Compare policies based on expiry date for sorting
        public int CompareTo(Policy other)
        {
            return ExpiryDate.CompareTo(other.ExpiryDate);
        }

        // Override Equals & GetHashCode for HashSet uniqueness
        public override bool Equals(object obj)
        {
            return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public override string ToString()
        {
            return $"Policy: {PolicyNumber}, Coverage: {CoverageType}, Expiry: {ExpiryDate.ToShortDateString()}";
        }
    }

    class InsurancePolicyManagementSystem
    {
        private HashSet<Policy> policySet = new HashSet<Policy>();
        private LinkedList<Policy> policyList = new LinkedList<Policy>();
        private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>();

        // Add a new policy (ensuring uniqueness)
        public void AddPolicy(Policy policy)
        {
            if (policySet.Add(policy)) // Ensures unique policy numbers
            {
                policyList.AddLast(policy);
                sortedPolicies.Add(policy);
            }
        }

        // Retrieve all policies
        public void DisplayAllPolicies()
        {
            Console.WriteLine("All Unique Policies:");
            foreach (var policy in policyList)
            {
                Console.WriteLine(policy);
            }
        }

        // Retrieve policies expiring within 30 days
        public void GetExpiringPolicies()
        {
            Console.WriteLine("\nPolicies Expiring Soon (Next 30 Days):");
            DateTime today = DateTime.Today;
            foreach (var policy in sortedPolicies)
            {
                if ((policy.ExpiryDate - today).TotalDays <= 30)
                {
                    Console.WriteLine(policy);
                }
            }
        }

        // Retrieve policies based on coverage type
        public void GetPoliciesByCoverage(string coverageType)
        {
            Console.WriteLine($"\nPolicies with Coverage Type: {coverageType}");
            foreach (var policy in policyList.Where(p => p.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine(policy);
            }
        }

        // Find duplicate policies based on policy number
        public void FindDuplicatePolicies()
        {
            Console.WriteLine("\nDuplicate Policies:");
            var duplicates = policyList.GroupBy(p => p.PolicyNumber).Where(g => g.Count() > 1);
            foreach (var group in duplicates)
            {
                foreach (var policy in group)
                {
                    Console.WriteLine(policy);
                }
            }
        }

        public void DisplayInsurance()
        {
            InsurancePolicyManagementSystem system = new InsurancePolicyManagementSystem();

            // Adding sample policies
            system.AddPolicy(new Policy("P1001", "Health", DateTime.Today.AddDays(10)));
            system.AddPolicy(new Policy("P1002", "Auto", DateTime.Today.AddDays(40)));
            system.AddPolicy(new Policy("P1003", "Home", DateTime.Today.AddDays(25)));
            system.AddPolicy(new Policy("P1004", "Health", DateTime.Today.AddDays(5)));
            system.AddPolicy(new Policy("P1001", "Health", DateTime.Today.AddDays(10))); // Duplicate, will be ignored

            system.DisplayAllPolicies();
            system.GetExpiringPolicies();
            system.GetPoliciesByCoverage("Health");
            system.FindDuplicatePolicies();
        }
    }

}
