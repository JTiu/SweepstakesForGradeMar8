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
        public string name { get; set; }
        public Sweepstakes(string Name)
        {
            this.name = Name;
        }
        public void RegisterContestant(CourtParticipant contestant) 
        {

        }
        //public CourtParticipant PickWinner()
        //{
        //    return new CourtParticipant();
        //}    
        public void PrintContestantInfo(CourtParticipant contestant)
        {
                
        }
    }

    



}





        

        
        

        //Dictionary<int CourtParticipant>  = new Dictionary<int>();
        //animals.Add("cat", "feline");
        //animals.Add("dog", "canine");
    

