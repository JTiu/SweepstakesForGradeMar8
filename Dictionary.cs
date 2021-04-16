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
            
            CourthouseParticipant ctHouseParticipant1 = new CourthouseParticipant();
            FirstName = "Jessica";
            LastName = "Jones";
            EmailAddress = "Jess@JS.com";
            RegistrationID = "345";
            NextCourtDate = "Apr25";
            Console.WriteLine($"Dictionary Class, method = 'createDictionaryParticipants' First/LastName = {FirstName}{LastName}");
            Console.ReadLine();
            return ctHouseParticipant1;
        }

    }

}   

    

