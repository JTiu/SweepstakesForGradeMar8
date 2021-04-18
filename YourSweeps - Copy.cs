using NameSpaceSweepstakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    public class YourSweepstakes : ISweepstakes
    {
        public void InsertSweepstakes()
        {
            // Program gives name here
            Console.WriteLine("YOUR SWEEPS también tiene un método llamado'InsertSweepstakes'");
            Console.WriteLine("Somos 'YOUR SWEEPS' Implementación de inserción!");
            Console.ReadLine();
        }
        public void GetSweepstakes()
        {
            // Program registers Participant here
            Console.WriteLine("También puede 'YOUR SWEEPS', pero de una manera diferente!");
            Console.WriteLine("Tenemos YOUR SWEEPS aquí mismo!");
            Console.ReadLine();
        }
        public void Welcome()
        {
            Console.WriteLine("Bienvenido a la lotería de juegos deportivos YOUR SWEEPS!");
            Console.ReadLine();
        }
        public void Exit()
        {
            Console.WriteLine("Buenos viajes te vas de la lotería YOUR SWEEPS!/ The Sweepstakes thanks you and wishes you good luck!");
            Console.ReadLine();
        }
        public void GetStack()
        {
            {
                //Console.WriteLine("The Sweepstakes class initiates Interface'ISweepstakes'\nOther classes, 'MySweeps' and 'Your Sweeps', implement the ISweepstakes interface.");
                //Console.WriteLine();

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

        public void GetQueue()
        {
            Console.WriteLine("Hello & Welcome to the Sweepstakes!\nBienvenido a la lotería de juegos deportivos!");
            System.Collections.Queue q = new System.Collections.Queue();

            q.Enqueue("Sweeper1,");
            q.Enqueue("Sweeper2,");
            q.Enqueue("Sweeper3,");
            q.Enqueue("Sweeper4,");
            Console.WriteLine();
            Console.WriteLine("Current sweepers queue: ");

            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Add two sweepers");

            q.Enqueue("Sweeper5,");
            q.Enqueue("Sweeper6,");
            Console.WriteLine();
            Console.WriteLine("Current sweepers queue: ");
            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Remove two sweepers");
            string ch = (string)q.Dequeue();
            Console.WriteLine();
            Console.WriteLine("The removed sweeper: {0}", ch);
            ch = (string)q.Dequeue();
            Console.WriteLine("The removed sweeper: {0}", ch);
            Console.WriteLine();
            Console.WriteLine("Current sweepers queue: ");

            foreach (string c in q) Console.Write(c + " ");
            Console.ReadLine();
            Console.ReadKey();

        }
        public void NextMethodOption1()
        {
            Console.WriteLine("next next option??");
            Console.ReadLine();
        }
    }
}

