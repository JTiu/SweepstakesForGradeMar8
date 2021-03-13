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
            //{
            //    // Creating a dictionary 
            //    // using Dictionary<TKey,TValue> class 
            //    Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

            //    // Adding key/value pairs  
            //    // in the Dictionary 
            //    // Using Add() method 

            //    //My_dict1.Add(1, "Mary");
            //    //My_dict1.Add(2, "Todd" );
            //    //My_dict1.Add(3, "Lincoln");

            //    foreach (KeyValuePair<int, string> ele1 in My_dict1)
            //    {
            //        Console.WriteLine("{0} and {1}",
            //                  ele1.Key, ele1.Value);
            //    }
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}

            //1 todo create while loop to comne back to menu after action completed 
            //2 todo create other views for each option 
            

            Menu startMenu = new Menu();
            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();


            int optionPicked;

            optionPicked = startMenu.DrawMenu();

            while (optionPicked != 7)
            {
                Console.Clear();
                //insert optionPicked into DirectUser in order to route user
                startMenu.DirectUser(optionPicked);
                Console.Clear();
                //Create Menu, capture menu selection into optionPicked
                optionPicked = startMenu.DrawMenu();
           
            }

            Console.WriteLine("Press any button to exit application");

            Console.ReadKey();
        }
    }
}
