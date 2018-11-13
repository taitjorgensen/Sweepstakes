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
        public void InsertSweepstakes()
        {

        }

        public Sweepstakes GetSweepstakes()
        {

            return sweepstakes;
        }
    }
}
