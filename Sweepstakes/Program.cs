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
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant c1 = new Contestant("", "", "");
            Contestant c2 = new Contestant("Jane", "Doe", "janedoe@email.com");
            Contestant c3 = new Contestant("Ron", "Doe", "Rondoe@email.com");

            sweepstakes.RegisterContestant(c1);
            Console.ReadLine();


        }
    }
}
