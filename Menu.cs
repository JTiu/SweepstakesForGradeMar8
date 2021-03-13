using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    public class Menu
    {

        //Variable HAS A








        //Methods

        public int DrawMenu()  //going to draw my menu of choices, contestant, sweep, winner
        {
            Console.WriteLine("James' Lucky Winners Sweepstakes");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Enter in contestant information");
            Console.WriteLine("2. List all contestants");
            Console.WriteLine("3. Create Sweepstakes");
            Console.WriteLine("4. List all Sweepstakes");
            Console.WriteLine("5. Pick Winner");
            Console.WriteLine("6. List Winners");
            Console.WriteLine("7. Exit Application");

            bool invalidEntry = true;
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
                    Console.WriteLine("Entry was incorrect, please enter 1-6");
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
                    Contestant contestant = new Contestant();
                    contestant.CreateContestant();
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                default:
                    break;
            }
        }
    }
}
