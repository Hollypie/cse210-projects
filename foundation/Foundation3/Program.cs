// Author: Holly Briggs, 10/26/2024

using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        RunningActivity runningActivity = new RunningActivity(30, 10);
        Console.WriteLine(runningActivity.GetSummary());
    }
}