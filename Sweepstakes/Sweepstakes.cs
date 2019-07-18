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
        Dictionary<int, Contestant> dictionaryContestant;




        //constructor
        public Sweepstakes(string name)
        {
            //name = UserInterface.SweepstakesName(); - create a method in the UI that prompts the firm to create a name for the sweepstakes
            dictionaryContestant = new Dictionary<int, Contestant>();
        }




        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            UserInterface.SetRegistrationNumber(contestant);
            UserInterface.SetFirstName(contestant);
            UserInterface.SetLastName(contestant);
            UserInterface.SetEmail(contestant);
            dictionaryContestant.Add(contestant.registrationNumber, contestant); //end of method
        }

        public string PickWinner()
        {
            Random newWinner = new Random();
            string outputWinner;
            int winner = newWinner.Next(dictionaryContestant.Count);
            outputWinner = $"{dictionaryContestant[winner].registrationNumber}: {dictionaryContestant[winner].firstName} {dictionaryContestant[winner].lastName} has won the contest!";
            return outputWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantUI(contestant);
        }
    }
}
