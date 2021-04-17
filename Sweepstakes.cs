using SweepstakesFeb9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    public class Sweepstakes
        //As a developer, I want to create a Sweepstakes class that uses the Dictionary data structure as an underlying structure.
       
    {
     
        public void PrintContestantInfo()
        {

            {

                Console.WriteLine("The program class initiates Interface'ISweepstakes'\nOther classes, 'MySweeps' and 'Your Sweeps', implement the ISweepstakes interface.");
                Console.WriteLine();
                MySweeps mySweepstakeClass = new MySweeps();  // Create a MySweeps object
                mySweepstakeClass.InsertSweepstakes();
                mySweepstakeClass.GetSweepstakes();

                YourSweepstakes yourSweeps = new YourSweepstakes();
                yourSweeps.InsertSweepstakes();
                yourSweeps.GetSweepstakes();



                Console.WriteLine("This is a stack in the Interface Class");
                Console.WriteLine("List elements in stack");
                System.Collections.Stack st2 = new System.Collections.Stack();
                st2.Push("now");
                st2.Push("programmer");
                st2.Push("am a");
                st2.Push("I");

                foreach (Object obj in st2)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadKey();
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Pop element from the stack");
                st2.Pop();
                Console.WriteLine();
                foreach (Object obj in st2)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadKey();

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Pop another element from the stack");
                //Stack st3 = new Stack();
                st2.Pop();
                Console.WriteLine();
                foreach (Object obj in st2)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadKey();
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Pop another element from the stack");
                //Stack st3 = new Stack();
                st2.Pop();
                Console.WriteLine();
                foreach (Object obj in st2)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadKey();

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine();
                Console.WriteLine("Push elements one by one");
                Console.WriteLine();
                st2.Push("programmer");
                st2.Push("am a");
                st2.Push("I");
                foreach (Object obj in st2)
                {
                    Console.WriteLine(obj);
                    Console.ReadLine();
                }
            }
        }

        public void NextMethodOption()
        {
            Console.WriteLine("next option??");
            Console.ReadLine();
        }
    }

    



}





        

        
        

        //Dictionary<int CourtParticipant>  = new Dictionary<int>();
        //animals.Add("cat", "feline");
        //animals.Add("dog", "canine");
    

