using SweepstakesFeb9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtHearing
{
    public class Sweepstakes
    {
        public void PrintContestantInfo()
        {
            {
                //Console.WriteLine("This app has an Interface'ISweepstakes'\nOther classes, 'MySweeps' and 'Your Sweeps', implement 'ISweepstakes'.");
                //Console.WriteLine();

                MySweeps mySweepstakeClass = new MySweeps();  // Create a MySweeps object
                //mySweepstakeClass.Welcome();
                //mySweepstakeClass.InsertSweepstakes();
                //mySweepstakeClass.GetSweepstakes();
                //mySweepstakeClass.Exit();

                YourSweepstakes yourSweeps = new YourSweepstakes();
                //yourSweeps.InsertSweepstakes();
                //yourSweeps.GetSweepstakes();
                //mySweepstakeClass.GetSweepstakes();
                //mySweepstakeClass.Exit();


                Console.WriteLine("This is the stack demo, Pop & Push");
                Console.WriteLine();
                Console.WriteLine("List elements in stack:");
                Console.WriteLine();
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
                Console.Clear();

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
            Console.WriteLine("The Sweepstakes Queue Demo!\nBienvenido a la lotería de juegos deportivos! Veamos 'Q'!");
            System.Collections.Queue q = new System.Collections.Queue();

            q.Enqueue("Sweeper1,");
            q.Enqueue("Sweeper2,");
            q.Enqueue("Sweeper3,");
            q.Enqueue("Sweeper4,");
            Console.WriteLine();
            Console.WriteLine("This is the current Sweepers Queue: ");

            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Add two Sweepers to the Queue");

            q.Enqueue("Sweeper5,");
            q.Enqueue("Sweeper6,");
            Console.WriteLine();
            Console.WriteLine("Current Sweepers queue: ");
            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Remove two Sweepers");
            string ch = (string)q.Dequeue();
            Console.WriteLine();
            Console.WriteLine("The removed Sweeper: {0}", ch);
            ch = (string)q.Dequeue();
            Console.WriteLine("The removed Sweeper: {0}", ch);
            Console.WriteLine();
            Console.WriteLine("Back to the original Sweepers Queue! ");

            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.ReadKey();
        }
        public void FullImplementation()
        {
            Console.WriteLine("Implement 'Get' & 'Insert', and 'Welcome' & 'Exit'");
            Console.ReadLine();
            Console.WriteLine("This app has an Interface'ISweepstakes'\nOther classes, 'MySweeps' and 'Your Sweeps', implement 'ISweepstakes'.");
            Console.WriteLine();

            MySweeps mySweepstakeClass = new MySweeps();  // Create a MySweeps object
            mySweepstakeClass.Welcome();
            mySweepstakeClass.InsertSweepstakes();
            mySweepstakeClass.GetSweepstakes();
            mySweepstakeClass.Exit();
            

            YourSweepstakes yourSweeps = new YourSweepstakes();
            yourSweeps.Welcome();
            yourSweeps.InsertSweepstakes();
            yourSweeps.GetSweepstakes();
            yourSweeps.Exit();

        }
        public void NextMethodOption2()
        {
            Console.WriteLine("next next option??");
            Console.ReadLine();
        }
    }

    



}





        

        
        

        //Dictionary<int SweepsParticipant>  = new Dictionary<int>();
        //animals.Add("cat", "feline");
        //animals.Add("dog", "canine");
    

