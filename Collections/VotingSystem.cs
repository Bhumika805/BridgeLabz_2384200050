using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class VotingSystem
    {
        private Dictionary<string, int> voteCounts;  // Stores candidate votes
        private SortedDictionary<string, int> sortedResults;  // Displays sorted results
        private LinkedList<string> voteOrder;  // Maintains order of votes

        public VotingSystem()
        {
            voteCounts = new Dictionary<string, int>();
            sortedResults = new SortedDictionary<string, int>();
            voteOrder = new LinkedList<string>();
        }

        // Cast a vote for a candidate
        public void CastVote(string candidate)
        {
            if (voteCounts.ContainsKey(candidate))
            {
                voteCounts[candidate]++;
            }
            else
            {
                voteCounts[candidate] = 1;
            }

            // Maintain order of votes cast
            voteOrder.AddLast(candidate);
        }

        // Display votes in order they were cast
        public void DisplayVoteOrder()
        {
            Console.WriteLine("Votes in Order Cast:");
            foreach (var candidate in voteOrder)
            {
                Console.Write(candidate + " ");
            }
            Console.WriteLine();
        }

        // Display results in alphabetical order
        public void DisplaySortedResults()
        {
            sortedResults = new SortedDictionary<string, int>(voteCounts);
            Console.WriteLine("\nElection Results (Alphabetical Order):");
            foreach (var entry in sortedResults)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} votes");
            }
        }

        public void DisplayVotingSystem()
        {
            VotingSystem votingSystem = new VotingSystem();

            // Simulating votes
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");
            votingSystem.CastVote("Charlie");
            votingSystem.CastVote("Bob");
            votingSystem.CastVote("Alice");

            votingSystem.DisplayVoteOrder();
            votingSystem.DisplaySortedResults();
        }
    }

}
