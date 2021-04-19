using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceSweepstakes
{
    public class SweepsParticipant
    {//Variable HAS :  As a developer, I want to create a SweepsParticipant class that has a first name, last name, email address, and registration number

        public string FirstName { get; set; }
        public string ChooseSweeps { get; set; }

        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string RegistrationID { get; set; }

        public string SweepsChoice { get; set; }


        ////Method CAN DO
        
        public RegisteredSweepsParticipant CreateParticipant()
        {
            RegisteredSweepsParticipant newParticipant = new RegisteredSweepsParticipant();
            newParticipant.FirstName = UserInterface.GetUserFirstName();
            newParticipant.LastName = UserInterface.GetUserLastName();
            newParticipant.EmailAddress = UserInterface.GetUserEmailAddress();
            newParticipant.RegistrationID = UserInterface.GetUserRegistrationNumber();
            newParticipant.NextCourtDate = UserInterface.GetUserChoice();
            Console.WriteLine("Sweepstakes Participant Info: First Name:   " + newParticipant.FirstName + "     Last Name:  " + newParticipant.LastName + ", Email:" + newParticipant.EmailAddress + ";  Sweeps Choice: " + newParticipant.NextCourtDate);
            Console.ReadLine();
            return newParticipant;
        }
        public RegisteredSweepsParticipant PickWinner()
        {
            RegisteredSweepsParticipant winner = new RegisteredSweepsParticipant();
            winner.FirstName = UserInterface.GetUserFirstName();
            winner.LastName = UserInterface.GetUserLastName();
            winner.EmailAddress = UserInterface.GetUserEmailAddress();
            winner.RegistrationID = UserInterface.GetUserRegistrationNumber();
            winner.NextCourtDate = UserInterface.GetUserChoice();
            Console.WriteLine("Sweepstakes Participant Info: First Name:   " + winner.FirstName + "     Last Name:  " + winner.LastName + ", Email:" + winner.EmailAddress + ";  Sweeps Choice: " + winner.NextCourtDate);
            Console.ReadLine();
            return winner;
        }

    }
}
