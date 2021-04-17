using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    public class Menu
    {


        public int DrawMenu()  //going to draw my menu of choices, contestant, sweep, winner
        {
            Console.WriteLine("Sweepstakes: Welcome!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Enter in Participant information [CreateParticipant]");
            Console.WriteLine("2. List all Participants, then register Participants[Create Dictionary, Register]");
            Console.WriteLine("3. Go to ISweepstakes [Stack data structure]");
            Console.WriteLine("4. Go to Queue Manager");
            Console.WriteLine("5. Designate Jurors");
            Console.WriteLine("6. List Jurors");
            Console.WriteLine("7. Exit Application");

            bool invalidEntry = true; //this bool insures that an invalid entry is not entered
            string result = "";

            while(invalidEntry == true)
            {
                result = Console.ReadLine();

                if (isValidEntry(result) == true)
                {
                    invalidEntry = false;
                }
                else
                {
                    Console.WriteLine("Entry was incorrect, please enter 1-7");
                }
            }

            return int.Parse(result);
        }
        public bool isValidEntry(string result)
        {

            //This method will chck two things: 1) if th string can b pars to an int 2) if they entered an int - was the int 1-6 (EX: 15 is not a menu option)
            int number;
            bool isNumeric = int.TryParse(result, out number); //This is a method that checks if a string can be parsed into a int. EX: "2" - this would return TRUE, EX: "greg" this would return FALSE

            if(isNumeric == true)
            {
                if(number < 8 && number > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void DirectUser(int option)
        {
            Console.Clear();

            switch(option)
            {
                case 1:
                    CourtParticipant contestant1 = new CourtParticipant();
                    contestant1.CreateCourtParticipant();
                    break;
                case 2:
                    CourthouseParticipant contestant2 = new CourthouseParticipant();
                    contestant2.CreateDictionaryParticipants();
                    break;
                case 3:
                    Sweepstakes contestant3 = new Sweepstakes();
                    contestant3.PrintContestantInfo();
                    break;
                case 4:
                    Sweepstakes contestant4 = new Sweepstakes();
                    contestant4.NextMethodOption();
                    break;
                case 5:
                    Sweepstakes contestant5 = new Sweepstakes();
                    contestant5.NextMethodOption1();
                    break;
                case 6:

                    break;
                default:
                    break;
            }
        }
    }
}
