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
            Console.WriteLine("Please enter contestant's email address:");
            contestant.email = Console.ReadLine();
        }

        public static void SetRegistrationNumber(Contestant contestant)
        {
            Console.WriteLine("Please enter contestant's registration number");
            contestant.registrationNumber = Convert.ToInt32(Console.ReadLine());
        }

        //public static string UserEmailValidation()
        //{
        //    bool validEmail = false;
        //    string userEmail = "";
        //    Console.WriteLine("Please enter contestant's email address:");
        //    while (!validEmail)
        //    {
        //        if (!userEmail.Contains("@") && !userEmail.Contains("."))
        //        {
        //            Console.WriteLine("Invalid input, please try again.");
        //            break;
        //        }

        //        else
        //        {
        //            validEmail = true;
        //        }
        //    }
        //    return userEmail;
        //}

        public static void PrintContestantUI(Contestant contestant)
        {
            Console.WriteLine($"{contestant.registrationNumber}: {contestant.firstName} {contestant.lastName}, {contestant.email}");
        }

		public static string ChooseManagerProgram()
		{
			Console.WriteLine("Which manager program would you like to use?: Stack or Queue");
			string input = Console.ReadLine();
			return input;
		}
	}
}
