using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes : ISweepstakesManager
    {
        Sweepstakes sweepstakes;
        private string winner;
        Contestant contestant;
        UI userInterface;
        //methods
        public void InsertSweepstakes()
        {

        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakes;
        }
        private void RegisterContestant()
        {
            contestant = new Contestant();
            userInterface.EnterContestantInfo(contestant);
        }
        private string PickWinner()
        {
            return winner;
        }
        private void PrintContestantInfo()
        {

        }
    }
}
