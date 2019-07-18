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
			ISweepstakesManager manager = null;
			switch (managerTool)
			{
				case "Stack":
					manager = new SweepstakesStackManager();
					break;
				case "Queue":
					manager = new SweepstakesQueueManager();
					break;
				default:
					Console.WriteLine("Not a valid manager program");
					break;
			}
			return manager;
		}
	}
}
