using System;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        int enteredNum = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        while (!(enteredNum == 0))
        {
        Console.Write("Enter number: ");
        string eNumber = Console.ReadLine();
        enteredNum = int.Parse(eNumber);

        if (!(enteredNum == 0))
        {
            numbers.Add(enteredNum);
        }
        
        }

        double sum = 0;
        int largestNum = 0;
        double ave = 0;
        int smallestPosNum = 1000000000;


        foreach (int number in numbers)
        {
            sum = number + sum;
            ave = sum / numbers.Count;

            if (number > largestNum)
            {
                largestNum = number;
            }

            if (number > 0)
            {
                if (number < smallestPosNum)
                {
                    smallestPosNum = number;
                }
            }
            
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {largestNum}.");
        Console.WriteLine($"The smallest positive number is: {smallestPosNum}");
        Console.WriteLine("The sorted list is: ");

        numbers.Sort();

        foreach (int sortedNumber in numbers)
        {
            Console.WriteLine(sortedNumber);
        }

        
        


    }
}