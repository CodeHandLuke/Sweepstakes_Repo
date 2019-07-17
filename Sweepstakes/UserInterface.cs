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
            Console.WriteLine("Please enter your first name:");
            contestant.firstName = Console.ReadLine();
        }

        public static void SetLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your last name:");
            contestant.lastName = Console.ReadLine();
        }

        public static void SetEmail(Contestant contestant)
        {
            string userInput;
            Console.WriteLine("Please enter your email address:");
            userInput = Console.ReadLine();
            UserEmailValidation(userInput); //maybe change and not use validation or find a better way to call this method
        }

        public static string UserEmailValidation(string userInput)
        {
            bool validEmail = false;
            string userEmail = "";

            while (!validEmail)
            {
                if (!userEmail.Contains("@") && !userEmail.Contains("."))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    break;
                }

                else
                {
                    validEmail = true;
                }
            }
            return userEmail;
        }

    }
}
