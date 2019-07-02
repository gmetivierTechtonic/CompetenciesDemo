using System;

// Namespace
namespace ColorGuessingGame
{
    //Main Class
    public class Class1
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); //get app info
            GreetUser(); //get user info & greet


            while (true)
            {
                //int correct number
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();

                //Init guess var
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a number");

                        //keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again");
                    }

                }

                //print sucess message!
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get anser
                string answer = Console.ReadLine().ToUpper();

                //Restarting the game
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        //get and display app info
        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Grace Metivier";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Magenta;

            //rite out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //ask user's name & greet
        static void GreetUser()
        {
            //run GetAppInfo() to get user's info
            GetAppInfo();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //tell user guess is not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}

