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

        //Constructor SPAWN

        public Contestant(string FirstName, string LastName, string EmailAddress, string RegistrationID)
        {
        //this.FirstName = UserInterface.GetFirstName(); 
             
        // for each variable, we want a method inside of the user interface class, that returns the correct string value
        //    //created user interface class, ceated GetFirstName method
         this.FirstName = FirstName;
         this.LastName = LastName;
         this.EmailAddress = EmailAddress;
         this.RegistrationID = RegistrationID;
        }

        public Contestant()
        {
        }
        ////Method CAN DO
    }
}
