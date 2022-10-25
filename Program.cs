using System;

// Namespace
namespace NumberGuesser
{
  // Main Class
  class Program
  {
    static void Main(string[] args)
    {

      GetAppInfo();
    
      GreetUser();

      while (true)
      {

        // Generate Random Number
        Random random = new Random();

        // Init Correct Number
        int correctNumber = random.Next(1, 10);

        // Init Guess Variable
        int guess = 0;

        // Hint Users About The Guess Range
        Console.WriteLine("Guess a number between 0 and 10");

        while (guess != correctNumber)
        {
          // Get Users Input
          string input = Console.ReadLine();

          // Confirm That Input Is A Number
          if (!int.TryParse(input, out guess))
          {
           
          //  Print Error Message
           PrintColorMessage(ConsoleColor.Red, "Wrong, that input is not a number, please type a number");

            // Keep Going
            continue;
          }

          // Cast To Int And Put In guess
          guess = Int32.Parse(input);

          if (guess != correctNumber)
          {
            //  Print Error Message
            PrintColorMessage(ConsoleColor.Red, "Wrong, that input is not the right number, please try again");
          }
        }

        // Output Success Message
        // Change Text Color

        //  Print Success Message
        PrintColorMessage(ConsoleColor.Yellow, "Super, that is the right number, BRAVO!!!");

        // Ask User To Play Again
        Console.WriteLine("Play Again? [Y] or [N]");

        // Get Reply
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
          continue;
        } else if (answer == "N")
        {
          return;
        } else
        {
          return;
        }

      }

    }
    

  // Get And Display App Info
    static void GetAppInfo()
    {

      // Set Application Variables
      string appName = "Number Guesser";
      string appVersion = "1.0.0";
      string appAuthor = "John Champion";

      // Change Text Color
      Console.ForegroundColor = ConsoleColor.Green;

      // Application Information
      Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

      // Reset Text Color
      Console.ResetColor();
    }

    static void GreetUser() 
    {
      // Ask Users For Their Name
      Console.WriteLine("What is your name?");

      // Get Users Input
      string inputName = Console.ReadLine();

      Console.WriteLine("Hello {0}, let's play a game...", inputName);
    }

    static void PrintColorMessage(ConsoleColor color, string message)
    {
      // Change Text Color
      Console.ForegroundColor = color;
      
      // Tell User, Input Type Is Not A Number
      Console.WriteLine(message);

      // Reset Text Color
      Console.ResetColor();
    }

  }
  
}