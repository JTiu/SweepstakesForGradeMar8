using CourtHearing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    public class MySweeps : ISweepstakes
    {
        public void InsertSweepstakes()
        {
            // Program gives name here
            Console.WriteLine("'MySweeps' class has a method to 'InsertSweepstakes'");
            Console.WriteLine("This is the MYSWEEPS insertion");
            Console.ReadLine();
        }
        public void GetSweepstakes()
        {
            // Program registers Participant here
            Console.WriteLine("The'MySweeps' class also has the 'Get Sweepstakes' method");
            Console.WriteLine("This is MYSWEEPS. Get your sweepstakes here");
            Console.ReadLine();
        }
    }
}
