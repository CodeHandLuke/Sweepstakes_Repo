using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
	public static class ManagerFactory
	{
		public static ISweepstakesManager ChooseManagerProgram(string managerTool)
		{
			bool validInput = false;
			ISweepstakesManager manager = null;
			while (!validInput)
			{
				switch (managerTool)
				{
					case "Stack":
						manager = new SweepstakesStackManager();
						validInput = true;
						break;
					case "Queue":
						manager = new SweepstakesQueueManager();
						validInput = true;
						break;
					default:
						Console.WriteLine("Not a valid manager program");
						break;
				}
			}
			return manager;
		}
	}
}
