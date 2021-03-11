using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    
    public class UserInterface
    {
        public static string GetUserFirstName()
        {
            Console.WriteLine("what is your first name?");
            var FirstName = Console.ReadLine();
            //Console.WriteLine($"The first name of contestant is: {FirstName}");
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
            Console.WriteLine("If you know your registration number, please enter here: ");
            var RegistrationID = Console.ReadLine();
            return RegistrationID;
        }




        public static void GetUserEmail(string EmailAddress)
        {
            Console.WriteLine($"The contestant's email address is: {EmailAddress}");
        }
        public static void GetBothNames(string FirstName, string LastName)
        {
            Console.WriteLine($"The next contestants' names are: {FirstName} {LastName}");
        }
        public static void GetRegistrationNumber(int RegistrationNumber) 
        {
            Console.WriteLine($"The next contestants' registration is {RegistrationNumber}");
            Console.ReadLine();
        }

    }
}
