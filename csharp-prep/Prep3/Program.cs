using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        
        while (playAgain == true)
        {
            int guessNumber = -1;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int numberOfGuesses = 0;

            while (!(guessNumber == magicNumber))
            {
                Console.Write("What is the guess number? ");
                string guessNum = Console.ReadLine();
                numberOfGuesses ++;
                guessNumber = int.Parse(guessNum);
                
                if (magicNumber == guessNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {numberOfGuesses} times to figure it out.");
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine("Higher");
                }

                
            }

            
            Console.WriteLine();
            Console.Write("Would you like to play again? y or n: ");
            string answer = Console.ReadLine();

            if (answer == "n")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing my guessing game.");
            }
            else
            {
                playAgain = true;
            }

        }
        
        
    }
}