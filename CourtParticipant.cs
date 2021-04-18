using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    public class CourtParticipant
    {//Variable HAS :  As a developer, I want to create a CourtParticipant class that has a first name, last name, email address, and registration number

        public string FirstName { get; set; }
        public string ChooseSweeps { get; set; }

        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string RegistrationID { get; set; }

        public string NextCourtDate { get; set; }


        ////Method CAN DO
        
        public CourthouseParticipant CreateCourtParticipant()
        {
            CourthouseParticipant courtParticipant = new CourthouseParticipant();
            courtParticipant.FirstName = UserInterface.GetUserFirstName();
            courtParticipant.LastName = UserInterface.GetUserLastName();
            courtParticipant.EmailAddress = UserInterface.GetUserEmailAddress();
            courtParticipant.RegistrationID = UserInterface.GetUserRegistrationNumber();
            courtParticipant.NextCourtDate = UserInterface.GetUserCourtDate();
            Console.WriteLine("Sweepstakes Participant Info: " + courtParticipant.FirstName + " " + courtParticipant.LastName + ", Email:" + courtParticipant.EmailAddress + "; RegID: " + courtParticipant.RegistrationID + "; Sweeps Choice: " + courtParticipant.NextCourtDate);
            Console.ReadLine();
            return courtParticipant;
        }
        
}
}
