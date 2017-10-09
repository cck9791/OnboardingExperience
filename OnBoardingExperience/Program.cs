using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            Console.WriteLine("Hey there! Welcome to our onboard experience.");

            user.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine("Awesome! Your name is " + user.FirstName);

            user.LastName = AskQuestion("What is your last name?");
            Console.WriteLine("Awesome! Your full name is " + user.FirstName + " " + user.LastName);

            user.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("Awesome! You are account owner: " + user.IsAccountOwner);

            user.PinNumber = AskPinNumber("What it your 4-digit pin?", 4);
            Console.WriteLine("Awesome! You entered: " + user.PinNumber);

            user.AccountNumber = AskNumberQuestion("What is your 9-digit account number?", 9);
            Console.WriteLine("Awesome! Your account number is: " + user.AccountNumber);
            Console.WriteLine("");
            Console.WriteLine("Thank you for your time! Have a great day!");
            Console.WriteLine("Press enter to exit.");

            Console.ReadLine();
        }

        public static string AskQuestion(string question)
        {
            string answer = null;

            while (string.IsNullOrEmpty(answer))
            {
                Console.WriteLine(question);
                answer = Console.ReadLine();
            }

            return answer;
        }

        static bool AskBoolQuestion(string question)
        {
            var hasAnswered = false;
            var responseBool = false;

            while (!hasAnswered)
            {
                var response = AskQuestion(question + " (y/n)");

                if (response == "y")
                {
                    responseBool = true;
                    hasAnswered = true;
                }
                else if (response == "n")
                {
                    responseBool = false;
                    hasAnswered = false;
                }
                
            }
            return responseBool;
        }

        static string AskPinNumber(string question, int limit)
        {
            string numberString = null;

            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == limit && Int32.TryParse(response, out int _))
                {
                    numberString = response;
                }
            }

            return numberString;
        }

        static string AskNumberQuestion(string question, int limit)
        {
            string numberString = null;

            while (numberString == null)
            {
                var response = AskQuestion(question);

                if (response.Length == limit && Int32.TryParse(response, out int _))
                {
                    numberString = response;
                }
            }

            return numberString;
        }
    }
}
