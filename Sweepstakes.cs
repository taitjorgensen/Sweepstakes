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
        private string winner;
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
        private Contestant PickWinner()
        {
            Random random = new Random((registeredContestants.Count) + 1000);

            Contestant winner = contestant;
            return winner;
        }
        private void PrintContestantInfo()
        {

        }
    }
}
