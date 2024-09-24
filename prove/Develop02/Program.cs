using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator thePromptGenerator = new PromptGenerator();
        
        bool continueProgram = true;
        while (continueProgram == true)
        {
            
            Entry anEntry = new Entry();
            
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. See Report");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                Console.WriteLine("1");
                
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                anEntry._date = dateText;
                anEntry._promptText = thePromptGenerator.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                string entryText = Console.ReadLine();
                anEntry._entryText = entryText;
                theJournal.AddEntry(anEntry);
                Console.WriteLine();
            }

            else if (userResponse == "2")
            {
                Console.WriteLine("2");
                theJournal.DisplayAll();
                Console.WriteLine();
            }

            else if (userResponse == "3")
            {
                Console.WriteLine("3");
                Console.WriteLine("What is the name of the file you want to load? ");
                string file = Console.ReadLine();
                Console.WriteLine("Loading from file...");
                theJournal.LoadFromFile(file);
                Console.WriteLine();
            }

            else if (userResponse == "4")
            {
                Console.WriteLine("4");
                Console.WriteLine("Please enter a filename: ");
                string fileText = Console.ReadLine();
                Console.WriteLine("Saving to file.... ");
                theJournal.SaveToFile(fileText);
                Console.WriteLine();
            }

            else if (userResponse == "5")
            {
                Console.WriteLine("Please enter the filename you want to display a report of: ");
                string reportFile = Console.ReadLine();
                
                theJournal.DisplayReport(reportFile);
                Console.WriteLine();
            }

            else if (userResponse == "6")
            {
                Console.WriteLine("You have chosen to exit program. Goodbye!");
                Console.WriteLine();
                System.Environment.Exit(0);
            }
        }
        
        
    }
}