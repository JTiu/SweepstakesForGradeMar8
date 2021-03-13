using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    public class Contestant
    {//Variable HAS :  As a developer, I want to create a Contestant class that has a first name, last name, email address, and registration number

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string RegistrationID { get; set; }

        ////Method CAN DO
        
        public Contestant CreateContestant()
        {
            Contestant contestant1 = new Contestant();
            contestant1.FirstName = UserInterface.GetUserFirstName();
            contestant1.LastName = UserInterface.GetUserLastName();
            contestant1.EmailAddress = UserInterface.GetUserEmailAddress();
            contestant1.RegistrationID = UserInterface.GetUserRegistrationNumber();
            Console.WriteLine("Contestant name: " + contestant1.FirstName + " " + contestant1.LastName + ", Email:" + contestant1.EmailAddress + "; RegID: " + contestant1.RegistrationID);

            return contestant1;
        }
    }
}
