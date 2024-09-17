using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a DisplayWelcome function that displays the message "Welcome to the Program!"        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Creates a PromptUserName function that asks for and returns the user's name as a string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        // Creates a PromptUserNumber function that returns the user's favorite number as an interger
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string favNum = Console.ReadLine();
            int number = int.Parse(favNum);
            return number;
        }
        // Creates a SquareNumber function that accepts an interger as a parameter and returns that number squared as an interger
        static int SquareNumber(int number)
        {
            int sqNum = number * number;
            return sqNum;
        }
        // Creates a DisplayResult function that accepts the user's name and the squared number and displays them.
        static void DisplayResult(int squareNumber, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {squareNumber}");
        }


        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(squareNumber, name);
    }
}