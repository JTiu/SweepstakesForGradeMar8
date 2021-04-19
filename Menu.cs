using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceSweepstakes
{
    public class Menu
    {


        public int DrawMenu()  //going to draw my menu of choices, contestant, sweep, winner
        {
            Console.WriteLine("Hello & Welcome to the Sweepstakes!\nBienvenido a la lotería de juegos deportivos!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Enter in Participant information [CreateParticipant, Print Info]");
            Console.WriteLine("2. List all Participants, then register Participants [Create Dictionary, Register]");
            Console.WriteLine("3. Choose/Examine the Stack");
            Console.WriteLine("4. Choose/Examine the Queue");
            Console.WriteLine("5. Implement Welcome, Insert, Get, Pick Winner, & Exit [ISweepstakes: Stack]");
            Console.WriteLine("6. Implement Welcome, Insert, Get, Pick Winner & Exit [ISweepstakes: Queue]");
            Console.WriteLine("7. Marketing Firm");
            Console.WriteLine("8. Exit Application");
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
                    Console.WriteLine("Entry was incorrect, please enter 1-8");
                }
            }

            return int.Parse(result);
        }
        public bool isValidEntry(string result)
        {

            //This method will chck two things: 1) if th string can b pars to an int 2) if they entered an int - was the int 1-6 (EX: 15 is not a menu option)
            int number;
            bool isNumeric = int.TryParse(result, out number); //This is a method that checks if a string can be parsed into a int. EX: "2" - this would return TRUE, EX: "joe" this would return FALSE

            if(isNumeric == true)
            {
                if(number < 9 && number > 0)
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
                    SweepsParticipant contestant1 = new SweepsParticipant();
                    contestant1.CreateParticipant();
                    break;
                case 2:
                    RegisteredSweepsParticipant contestant2 = new RegisteredSweepsParticipant();
                    contestant2.CreateDictionaryParticipants();
                    break;
                case 3:
                    Sweepstakes contestant3 = new Sweepstakes();
                    contestant3.StackContestantInfo();
                    break;
                case 4:
                    Sweepstakes contestant4 = new Sweepstakes();
                    contestant4.QueueContestantInfo();
                    break;
                case 5:
                    Sweepstakes contestant5 = new Sweepstakes();
                    contestant5.FullImplementation();
                    break;
                case 6:
                    Sweepstakes contestant6 = new Sweepstakes();
                    contestant6.ImplementacionCompleta();
                    break;
                case 7:
                    Sweepstakes contestant7 = new Sweepstakes();
                    contestant7.MarketingFirm();
                    break;
                case 8:
                    Sweepstakes contestant8 = new Sweepstakes();
                    contestant8.NextMethodOption3();
                    break;
                default:
                    break;
            }
        }
    }
}
