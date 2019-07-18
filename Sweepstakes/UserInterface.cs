using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {

        //member methods
        public static void SetFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter contestant's first name:");
            contestant.firstName = Console.ReadLine();
        }

        public static void SetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter contestant's last name:");
            contestant.lastName = Console.ReadLine();
        }

        public static void SetEmail(Contestant contestant)
        {
			bool validEmail = false;
			string userEmail = "";
			while (!validEmail)
			{
				Console.WriteLine("Please enter contestant's email address:");
				userEmail = Console.ReadLine();
				if (!userEmail.Contains("@") || !userEmail.Contains("."))
				{
					Console.WriteLine("Invalid input, please try again.");
				}

				else
				{
					validEmail = true;
				}
			}
			contestant.email = userEmail;
		}

		public static void PrintContestantUI(Contestant contestant)
        {
            Console.WriteLine($"{contestant.registrationNumber}: {contestant.firstName} {contestant.lastName}, {contestant.email}");
        }

		public static string ChooseManagerProgram()
		{
			string input = "";
			bool validInput = false;
			while (!validInput)
			{
				Console.WriteLine("Which manager program would you like to use?: Type in either 'Stack' or 'Queue' (case sensitive).");
				input = Console.ReadLine();
				switch (input)
				{
					case "Stack":
						validInput = true;
						return input;
					case "Queue":
						validInput = true;
						return input;
					default:
						Console.WriteLine("Not a valid manager program");
						break;
				}
			}
			return input;
		}
	}
}
