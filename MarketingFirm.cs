using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm : ISweepstakesManager
    {
        SweepstakesStackManager sweepstakesStackManager;
        SweepstakesQueueManager sweepstakesQueueManager;
        public void InsertSweepstakes()
        {
            Console.WriteLine("Please choose \"Stack\" or \"Queue\" management for your sweepstakes");
            string value = Console.ReadLine();
            value.ToLower();
            switch (value)
            {
                case "stack":
                    {
                        SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                        sweepstakesStackManager.GetSweepstakes();
                        break;
                    }
                case "queue":
                    {
                        SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                        sweepstakesQueueManager.GetSweepstakes();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter a valid response. \"Stack\" or \"Queue\"");
                        break;
                    }
            }
        }

        public Sweepstakes GetSweepstakes()
        {

        }
    }
}
