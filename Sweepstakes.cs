using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {               
        Contestant contestant;
        UI userInterface;
        private Contestant winner;
        Dictionary<int, Contestant> registeredContestants;

        //methods
        public void CreateSweepstakes(MarketingFirm marketingFirm, Sweepstakes sweepstakes)
        {
            marketingFirm.InsertSweepstakes(sweepstakes);
            registeredContestants = new Dictionary<int, Contestant>();
            userInterface = new UI();
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
