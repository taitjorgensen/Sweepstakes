using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Sweepstakes sweepstakes;
        private Contestant winner;
        Contestant contestant;
        UI userInterface;
        Dictionary<int, Contestant> registeredContestants;

        //methods
        public void CreateSweepstakes()
        {
            registeredContestants = new Dictionary<int, Contestant>();
            AddContestant();
        }
        private void AddContestant()
        {
            RegisterContestant();
            registeredContestants.Add(contestant.registrationNumber, contestant);
        }
        private void RegisterContestant()
        {
            contestant = new Contestant();
            userInterface.EnterContestantInfo(contestant);
        }
        private IEnumerable<Contestant> PickWinner()
        {
            Random random = new Random();
            List<Contestant> contestants = Enumerable.ToList(registeredContestants.Values);
            int numberOfEntrants = contestants.Count;
            while(true)
            {
                winner = contestants[random.Next(numberOfEntrants)];
                DisplayWinner();
                yield return winner;
            }

        }
        private void DisplayWinner()
        {
            Console.WriteLine(winner.FirstName + " " + winner.LastName + " has won the sweepstakes!");
            Console.ReadLine();
        }
        public void PrintContestantInfo()
        {
            Console.WriteLine("Contestant info: ");
            Console.WriteLine(registeredContestants.Values);
            Console.ReadLine();
        }
    }
}
