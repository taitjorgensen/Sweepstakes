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
