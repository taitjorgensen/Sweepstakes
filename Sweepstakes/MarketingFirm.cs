using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm : ISweepstakesManager
    {
        Sweepstakes sweepstakes;
        SweepstakesStackManager sweepstakesStackManager;
        SweepstakesQueueManager sweepstakesQueueManager;
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Please choose \"Stack\" or \"Queue\" management for your sweepstakes");
            string value = Console.ReadLine();
            value = value.ToLower();
            switch (value)
            {
                case "stack":
                    {
                        sweepstakesStackManager = new SweepstakesStackManager();
                        sweepstakesStackManager.InsertSweepstakes(sweepstakes);
                        break;
                    }
                case "queue":
                    {
                        sweepstakesQueueManager = new SweepstakesQueueManager();
                        sweepstakesQueueManager.InsertSweepstakes(sweepstakes);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter a valid response. \"Stack\" or \"Queue\"");
                        InsertSweepstakes(sweepstakes);
                        break;
                    }
            }
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakes;
        }

        public void BeginNewSweepstakes(MarketingFirm marketingFirm)
        {
            sweepstakes = new Sweepstakes();
            sweepstakes.CreateSweepstakes(marketingFirm, sweepstakes);
        }

        private void ViewContestants()
        {
            sweepstakes.PrintContestantInfo();
        }
    }
}
