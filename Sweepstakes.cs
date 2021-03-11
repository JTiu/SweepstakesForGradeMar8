using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesFeb9
{
    public class Sweepstakes
        //As a developer, I want to create a Sweepstakes class that uses the Dictionary data structure as an underlying structure.
       
    {
        public string name { get; set; }
        public Sweepstakes(string Name)
        {
            this.name = Name;
        }
        public void RegisterContestant(Contestant contestant) 
        {

        }
        //public Contestant PickWinner()
        //{
        //    return new Contestant();
        //}    
        public void PrintContestantInfo(Contestant contestant)
        {
                
        }
    }

    



}





        

        
        

        //Dictionary<int Contestant>  = new Dictionary<int>();
        //animals.Add("cat", "feline");
        //animals.Add("dog", "canine");
    

