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

			string managerStyle = UserInterface.ChooseManagerProgram();
			MarketingFirm bigShotMarketingFirm = new MarketingFirm(ManagerFactory.ChooseManagerProgram(managerStyle));


			string sweepstakesGame = "freeCandy";
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesGame);
            Contestant c1 = new Contestant("", "", "");
            Contestant c2 = new Contestant("", "", "");
            Contestant c3 = new Contestant("", "", "");


            sweepstakes.RegisterContestant(c1);
			Console.WriteLine("\n");
			sweepstakes.RegisterContestant(c2);
			Console.WriteLine("\n");
			sweepstakes.RegisterContestant(c3);
			Console.WriteLine("\n");
			UserInterface.PrintContestantUI(c1);
			UserInterface.PrintContestantUI(c2);
			UserInterface.PrintContestantUI(c3);
			Console.ReadLine();
		}
    }
}
