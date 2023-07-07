using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess the Number (^-^)");
        // Defining the number to be guessed
        Random random = new Random();
        int secretNumber = random.Next(1,101); // Returns a number between 1 and 100

        Console.WriteLine("I'm thinking in a number between 1 and 100.");

        for(int i = 0; i < 5; i++)
        {
            // Requesting the number to the player
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);
     
            // Game Logic
            if (guess > secretNumber)
            {
                Console.WriteLine("Uh oh, that's too high! Try again! :(");
            }
            else if(guess < secretNumber)
            {
                Console.WriteLine("Nope, that's too low, try again.");
            }
            else
            {
                Console.WriteLine("Congrats! You won! (^-^)"); 
                return; // This instruction ends the game 
            }
     
        }
        Console.WriteLine("Game Over >:(");
    } 
}