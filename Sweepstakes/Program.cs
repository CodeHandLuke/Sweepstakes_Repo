using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
			ISweepstakesManager managerProgram;
			string managerStyle = UserInterface.ChooseManagerProgram();
			managerProgram = ManagerFactory.ChooseManagerProgram(managerStyle);
			MarketingFirm bigShotMarketingFirm = new MarketingFirm(managerProgram);


			string sweepstakesGame = "freeCandy";
			Sweepstakes sweepstakes = new Sweepstakes(sweepstakesGame);
			Contestant c1 = new Contestant("Luke", "F", "Lukef@gmail.com");
			Contestant c2 = new Contestant("Jon", "Doe", "jondoe@gmail.com");
			Contestant c3 = new Contestant("Jane", "Doe", "jandoe@gmail.com");
			sweepstakes.RegisterContestant(c1);
			sweepstakes.RegisterContestant(c2);
			sweepstakes.RegisterContestant(c3);

			Console.WriteLine("\n");
			UserInterface.PrintContestantUI(c1);
			UserInterface.PrintContestantUI(c2);
			UserInterface.PrintContestantUI(c3);
			Console.WriteLine(sweepstakes.dictionaryContestant.Count);
			Console.ReadLine();
			sweepstakes.PickWinner();
			Console.ReadLine();
		}
    }
}
