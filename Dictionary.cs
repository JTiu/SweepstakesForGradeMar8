using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    public class CourthouseParticipant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string RegistrationID { get; set; }
        public string NextCourtDate { get; set; }

        public CourthouseParticipant CreateDictionaryParticipants()
        {

            CourthouseParticipant ctHouseParticipant1 = new CourthouseParticipant()
            {
                FirstName = "Jessica",
                LastName = "Jones",
                EmailAddress = "Jess@JS.com",
                RegistrationID = "345",
                NextCourtDate = "Apr25",

            };

            CourthouseParticipant ctHouseParticipant2 = new CourthouseParticipant()
            {
                FirstName = "Joe",
                LastName = "Smith",
                EmailAddress = "Joe@JS.com",
                RegistrationID = "123",
                NextCourtDate = "Apr24",

            };

            CourthouseParticipant ctHouseParticipant3 = new CourthouseParticipant()
            {
                FirstName = "Jeff",
                LastName = "Jones",
                EmailAddress = "Jeff@JS.com",
                RegistrationID = "234",
                NextCourtDate = "Apr22",

            };

            Dictionary<string, CourthouseParticipant> dictionaryCtHouseParticipants = new Dictionary<string, CourthouseParticipant>();
            dictionaryCtHouseParticipants.Add(ctHouseParticipant1.RegistrationID, ctHouseParticipant1);
            dictionaryCtHouseParticipants.Add(ctHouseParticipant2.RegistrationID, ctHouseParticipant2);
            dictionaryCtHouseParticipants.Add(ctHouseParticipant3.RegistrationID, ctHouseParticipant3);

            CourthouseParticipant courthouseParticipant345 = dictionaryCtHouseParticipants["345"];

            CourthouseParticipant courthouseParticipant123 = dictionaryCtHouseParticipants["123"];

            CourthouseParticipant courthouseParticipant234 = dictionaryCtHouseParticipants["234"];
          
            Console.WriteLine("ID = {0}/ FirstName = {1}/ LastName = {2}/ NextCourtDate = {3}", courthouseParticipant345.RegistrationID, courthouseParticipant345.FirstName, courthouseParticipant345.LastName, courthouseParticipant345.NextCourtDate);
          
            Console.WriteLine("ID = {0}/ FirstName = {1}/ LastName = {2}/ NextCourtDate = {3}", courthouseParticipant123.RegistrationID, courthouseParticipant123.FirstName, courthouseParticipant123.LastName, courthouseParticipant123.NextCourtDate);
       
            Console.WriteLine("ID = {0}/ FirstName = {1}/ LastName = {2}/ NextCourtDate = {3}", courthouseParticipant234.RegistrationID, courthouseParticipant234.FirstName, courthouseParticipant234.LastName, courthouseParticipant234.NextCourtDate);
            Console.ReadLine();

            foreach (KeyValuePair<string, CourthouseParticipant> participantKeyValuePair in dictionaryCtHouseParticipants)
            {
                Console.WriteLine("@hereID = {0}", participantKeyValuePair.Key);
                CourthouseParticipant ctHousePart = participantKeyValuePair.Value;
                Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, NextCourtDate = {3}", ctHousePart.RegistrationID, ctHousePart.FirstName, ctHousePart.LastName, ctHousePart.NextCourtDate);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.ReadLine();
            }
            return courthouseParticipant123;
        }
       
    }

}   

    

