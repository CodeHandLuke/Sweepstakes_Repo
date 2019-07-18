using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
		//member variables
		Queue<Sweepstakes> sweepstakesQeueu;



		//constructor
		public SweepstakesQueueManager()
		{
			sweepstakesQeueu = new Queue<Sweepstakes>();
		}



		//member methods
		public Sweepstakes GetSweepstakes()
		{
			return sweepstakesQeueu.Dequeue();
		}
		public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
			sweepstakesQeueu.Enqueue(sweepstakes);
        }
    }
}
