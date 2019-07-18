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
        public Dictionary<int, Contestant> dictionaryContestant;
		Random newWinner;
		int registrationNum;




        //constructor
        public Sweepstakes(string name)
        {
			newWinner = new Random();
			dictionaryContestant = new Dictionary<int, Contestant>();
			registrationNum = 0;
        }




        //member methods
        public void RegisterContestant(Contestant contestant)
        {
			contestant.registrationNumber = registrationNum;
			UserInterface.SetFirstName(contestant);
			UserInterface.SetLastName(contestant);
			UserInterface.SetEmail(contestant);
			dictionaryContestant.Add(registrationNum, contestant);
			registrationNum++;
        }

        public string PickWinner()
        {
            string outputWinner;
            int winner = newWinner.Next(dictionaryContestant.Count);
            outputWinner = $"{dictionaryContestant[winner].registrationNumber}: {dictionaryContestant[winner].firstName} {dictionaryContestant[winner].lastName} has won the contest!";
			Console.WriteLine(outputWinner);
			return outputWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantUI(contestant);
        }
    }
}
