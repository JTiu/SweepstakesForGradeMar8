using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceSweepstakes
{
    public class Program //does not need to run anything from here.
    {
        static void Main(string[] args)
        {
            Menu startMenu = new Menu();
           // Dictionary<int, SweepsParticipant> contestants = new Dictionary<int, SweepsParticipant>();


            int optionPicked;

             optionPicked = startMenu.DrawMenu(); //

            while (optionPicked != 7)
            {
                Console.Clear();
                //insert optionPicked into DirectUser in order to route user
                startMenu.DirectUser(optionPicked);
                Console.Clear();
                //Create Menu, capture menu selection into optionPicked
                optionPicked = startMenu.DrawMenu();
           
            }

            Console.WriteLine("Press any button to exit application");

            Console.ReadKey();
            
        }
    }
}
