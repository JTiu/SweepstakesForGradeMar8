using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceSweepstakes
{
    public class RegisteredSweepsParticipant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string RegistrationID { get; set; }
        public string NextCourtDate { get; set; }

        public RegisteredSweepsParticipant CreateDictionaryParticipants()
        {

            RegisteredSweepsParticipant ctHouseParticipant1 = new RegisteredSweepsParticipant()
            {
                FirstName = "Jessica",
                LastName = "Jones",
                EmailAddress = "Jess@JS.com",
                RegistrationID = "345",
                NextCourtDate = "Apr25",

            };

            RegisteredSweepsParticipant ctHouseParticipant2 = new RegisteredSweepsParticipant()
            {
                FirstName = "Joe",
                LastName = "Smith",
                EmailAddress = "Joe@JS.com",
                RegistrationID = "123",
                NextCourtDate = "Apr24",

            };

            RegisteredSweepsParticipant ctHouseParticipant3 = new RegisteredSweepsParticipant()
            {
                FirstName = "Jeff",
                LastName = "Jones",
                EmailAddress = "Jeff@JS.com",
                RegistrationID = "234",
                NextCourtDate = "Apr22",

            };

            Dictionary<string, RegisteredSweepsParticipant> dictionaryCtHouseParticipants = new Dictionary<string, RegisteredSweepsParticipant>();
            dictionaryCtHouseParticipants.Add(ctHouseParticipant1.RegistrationID, ctHouseParticipant1);
            dictionaryCtHouseParticipants.Add(ctHouseParticipant2.RegistrationID, ctHouseParticipant2);
            dictionaryCtHouseParticipants.Add(ctHouseParticipant3.RegistrationID, ctHouseParticipant3);

            RegisteredSweepsParticipant courthouseParticipant345 = dictionaryCtHouseParticipants["345"];

            RegisteredSweepsParticipant courthouseParticipant123 = dictionaryCtHouseParticipants["123"];

            RegisteredSweepsParticipant courthouseParticipant234 = dictionaryCtHouseParticipants["234"];
            Console.WriteLine("View all Participants press 'Enter' [List Dictionary]");
            Console.ReadLine();
            Console.WriteLine("FirstName = {1}/ LastName = {2}/ SweepsChoice = {3}", courthouseParticipant345.RegistrationID, courthouseParticipant345.FirstName, courthouseParticipant345.LastName, courthouseParticipant345.NextCourtDate);
          
            Console.WriteLine("FirstName = {1}/ LastName = {2}/ SweepsChoice = {3}", courthouseParticipant123.RegistrationID, courthouseParticipant123.FirstName, courthouseParticipant123.LastName, courthouseParticipant123.NextCourtDate);
       
            Console.WriteLine("FirstName = {1}/ LastName = {2}/ SweepsChoice = {3}", courthouseParticipant234.RegistrationID, courthouseParticipant234.FirstName, courthouseParticipant234.LastName, courthouseParticipant234.NextCourtDate);
            Console.ReadLine();
            Console.WriteLine("Register Participants, one--by-one, press 'Enter'");
            Console.ReadLine();
            foreach (KeyValuePair<string, RegisteredSweepsParticipant> participantKeyValuePair in dictionaryCtHouseParticipants)
            {
                Console.WriteLine("ID = {0}", participantKeyValuePair.Key);
                RegisteredSweepsParticipant ctHousePart = participantKeyValuePair.Value;
                Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, SweepsChoice = {3}", ctHousePart.RegistrationID, ctHousePart.FirstName, ctHousePart.LastName, ctHousePart.NextCourtDate);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ReadLine();
            }
            return courthouseParticipant123;
        }
       
    }

}   

    

