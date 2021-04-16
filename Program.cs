using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    public class Program //does not need to run anything from here.
    {
        static void Main(string[] args)
        {
            Menu startMenu = new Menu();
           // Dictionary<int, CourtParticipant> contestants = new Dictionary<int, CourtParticipant>();


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
            //create dictionary items here//
            //CourthouseParticipant ctHouseParticipant1 = new CourthouseParticipant()
            //{
            //    FirstName = "Jessica",
            //    LastName = "Jones",
            //    EmailAddress = "Jess@JS.com",
            //    RegistrationID = 345,
            //    NextCourtDate = "Apr25",

            //};

            //CourthouseParticipant ctHouseParticipant2 = new CourthouseParticipant()
            //{
            //    FirstName = "Joe",
            //    LastName = "Smith",
            //    EmailAddress = "Joe@JS.com",
            //    RegistrationID = 123,
            //    NextCourtDate = "Apr24",

            //};

            //CourthouseParticipant ctHouseParticipant3 = new CourthouseParticipant()
            //{
            //    FirstName = "Jeff",
            //    LastName = "Jones",
            //    EmailAddress = "Jeff@JS.com",
            //    RegistrationID = 234,
            //    NextCourtDate = "Apr22",

            //};

            //Dictionary<int, CourthouseParticipant> dictionaryCtHouseParticipants = new Dictionary<int, CourthouseParticipant>();
            //dictionaryCtHouseParticipants.Add(ctHouseParticipant1.RegistrationID, ctHouseParticipant1);
            //dictionaryCtHouseParticipants.Add(ctHouseParticipant2.RegistrationID, ctHouseParticipant2);
            //dictionaryCtHouseParticipants.Add(ctHouseParticipant3.RegistrationID, ctHouseParticipant3);

            //CourthouseParticipant courthouseParticipant345 = dictionaryCtHouseParticipants[345];

            //CourthouseParticipant courthouseParticipant123 = dictionaryCtHouseParticipants[123];

            //CourthouseParticipant courthouseParticipant234 = dictionaryCtHouseParticipants[234];
            //Console.WriteLine("");
            //Console.WriteLine("ID = {0}/ FirstName = {1}/ LastName = {2}/ NextCourtDate = {3}", courthouseParticipant345.RegistrationID, courthouseParticipant345.FirstName, courthouseParticipant345.LastName, courthouseParticipant345.NextCourtDate);
            //Console.ReadLine();
            //Console.WriteLine("ID = {0}/ FirstName = {1}/ LastName = {2}/ NextCourtDate = {3}", courthouseParticipant123.RegistrationID, courthouseParticipant123.FirstName, courthouseParticipant123.LastName, courthouseParticipant123.NextCourtDate);
            //Console.ReadLine();
            //Console.WriteLine("ID = {0}/ FirstName = {1}/ LastName = {2}/ NextCourtDate = {3}", courthouseParticipant234.RegistrationID, courthouseParticipant234.FirstName, courthouseParticipant234.LastName, courthouseParticipant234.NextCourtDate);
            //Console.ReadLine();

            //foreach (KeyValuePair<int, CourthouseParticipant> participantKeyValuePair in dictionaryCtHouseParticipants)
            //{
            //    Console.WriteLine("ID = {0}", participantKeyValuePair.Key);
            //    CourthouseParticipant ctHousePart = participantKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, NextCourtDate = {3}", ctHousePart.RegistrationID, ctHousePart.FirstName, ctHousePart.LastName, ctHousePart.NextCourtDate);
            //    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            //}
        }
    }
}
