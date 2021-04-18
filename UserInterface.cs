using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    
    public class UserInterface
    {
        public static string GetUserFirstName()
        {
            Console.WriteLine("What is your first name?");
            var FirstName = Console.ReadLine();
            return FirstName;
        }
        public static string GetUserLastName()
        {
            Console.WriteLine("What is your last name?");
            var LastName = Console.ReadLine();
            return LastName;
        }
        public static string GetUserEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            var EmailAddress = Console.ReadLine();
            return EmailAddress;
        }
        public static string GetUserRegistrationNumber()
        {
            Console.WriteLine("You will be assigned a registration mumber--press enter: ");
            var RegistrationID = Console.ReadLine();
            return RegistrationID;
        }
        public static string GetUserCourtDate()
        {
            Console.WriteLine("Would you like to enter 'MySweeps' or 'YourSweeps'?");
            var ChooseSweeps = Console.ReadLine();
            return ChooseSweeps;
        }


    }
}
