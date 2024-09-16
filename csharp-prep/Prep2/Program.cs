using System;

class Program
{
    static void Main(string[] args)
    {
        bool passed = true;
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int gradeNum = int.Parse(userGrade);
        Console.WriteLine();
        string letter = "U";

        if (gradeNum > 90)
        {
            letter = "A";
            passed = true;
        }
        else if (gradeNum > 80)
        {
            letter = "B";
            passed = true;
        }
        else if (gradeNum > 70)
        {
            letter = "C";
            passed = true;
        }
        else if (gradeNum > 60)
        {
            letter = "D";
            passed = false;
        }
        else
        {
            letter = "F";
            passed = false;
        }

        Console.Write($"You have a {letter}");

        if (!(gradeNum < 60))
        {
            if (gradeNum % 10 >= 7)
            {
                Console.Write("+");
            }
            else if (gradeNum % 10 < 3)
            {
                Console.Write("-");
            }

        }
        
        Console.WriteLine(); 

        if (passed == true)
        {
        
            Console.WriteLine("Congradulations you have passed the class.");
        }
        else
        {
            Console.WriteLine("You have not passed the class. You will need to retake this class. Better luck next time.");
        }
    }
}