using System;

class Program
{
    static void Main(string[] args)
    {
        // guessing game
        // getting random number
        Random random=new Random();
        string playAgain="yes";
        
        while (playAgain.ToLower() == "yes")
        {
            int magicNumber=random.Next(1,101);
            int guess=0;
            int guessCount=0;
            Console.WriteLine(" choose a number between 1- 100 to fulfill your guess");
            
            while (guess != magicNumber)
            {
                Console.WriteLine("Guess a number to win");
                guess=int.Parse(Console.ReadLine());
                guessCount++;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");

                }
                else
                {
                    Console.WriteLine("Congratulations, you guessed right");
                    Console.WriteLine($"It took you {guessCount} guesses to win");

                }

            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");

    }
}