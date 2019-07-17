using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        //member variables
        public int globalRegistrationNumber;
        Dictionary<int, Contestant> dictionaryContestant;




        //constructor
        public Sweepstakes(string name)
        {
            globalRegistrationNumber = 0001;
            dictionaryContestant = new Dictionary<int, Contestant>();
        }




        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            UserInterface.SetFirstName(contestant);
            contestant.registrationNumber = dictionaryContestant.Count; 
            dictionaryContestant.Add(dictionaryContestant.Count, contestant); //end of method
        }

        public string PickWinner()
        {
            return;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
