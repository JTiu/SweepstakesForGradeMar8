using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    public class Program //does not need to run anything from here.
    {
        static void Main(string[] args)
        {
            Contestant contestant1 = new Contestant();
            contestant1.FirstName = UserInterface.GetUserFirstName();
            contestant1.LastName = UserInterface.GetUserLastName();
            contestant1.EmailAddress = UserInterface.GetUserEmailAddress();
            contestant1.RegistrationID = UserInterface.GetUserRegistrationNumber();
            Console.WriteLine("Contestant name: " + contestant1.FirstName + " " + contestant1.LastName + ", Email:" + contestant1.EmailAddress + "; RegID: "+ contestant1.RegistrationID);

            {

                // Creating a dictionary 
                // using Dictionary<TKey,TValue> class 
                Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

                // Adding key/value pairs  
                // in the Dictionary 
                // Using Add() method 
                
                //My_dict1.Add(1, "Mary");
                //My_dict1.Add(2, "Todd" );
                //My_dict1.Add(3, "Lincoln");

                foreach (KeyValuePair<int, string> ele1 in My_dict1)
                {
                    Console.WriteLine("{0} and {1}",
                              ele1.Key, ele1.Value);
                }
                Console.WriteLine();
                Console.ReadLine();


               



            }
        }
    }
}
