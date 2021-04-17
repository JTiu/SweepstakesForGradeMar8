using CourtHearing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    class YourSweepstakes : ISweepstakes
    {
        public void InsertSweepstakes()
        {
            // Program gives name here
            Console.WriteLine("'YourSweeps' also has a method called 'InsertSweepstakes'");
            Console.WriteLine("We are YOURSWEEPS Insertion implementation");
            Console.ReadLine();
        }
        public void GetSweepstakes()
        {
            // Program registers Participant here
            Console.WriteLine("'YourSweeps' class may also 'RegisterParticipant, but in a different way");
            Console.WriteLine("We accept YOURSWEEPS Registration");
            Console.ReadLine();
        }
    }
}
