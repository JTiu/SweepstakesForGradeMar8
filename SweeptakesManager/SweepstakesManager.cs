using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing.SweeptakesManager
{
    public class SweepstakesManager : ISweepstakesManager //Interface creates a contract tha tthe class has to follow
    {
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            return new Sweepstakes(""); //This is an empty sweepstakes that satisfies the method for now
        }
    }
}
