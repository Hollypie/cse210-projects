using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // instantiate the Journal and PromptGenerator objects
        Journal theJournal = new Journal();
        PromptGenerator thePromptGenerator = new PromptGenerator();
        
        // initialize a boolean to create a condition for a while loop to continue program until the user wishes to terminate the program.
        bool continueProgram = true;
        while (continueProgram == true)
        {
            // instantiates an Entry object.
            Entry anEntry = new Entry();
            // Generates a menu of options for the user. Inquires what the user wishes to do.
            Console.WriteLine();
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
            Console.WriteLine();

            // takes the users request and determines which task the program should perform.
            if (userResponse == "1")
            {                
                // Populates previously created Entry object with data.
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
                // Displays all the Entries that were either created since the program began running and any Entries loaded from a previously saved file.
                theJournal.DisplayAll();
                Console.WriteLine();
            }

            else if (userResponse == "3")
            {
                // Loads all of the Entries previously saved to a file into the list of current entries.
                Console.WriteLine("What is the name of the file you want to load? include .txt in your response: ");
                string file = Console.ReadLine();
                Console.WriteLine("Loading from file...");
                theJournal.LoadFromFile(file);
                Console.WriteLine();
            }

            else if (userResponse == "4")
            {
                // Saves Entries from current list of entries to a text file.
                Console.WriteLine("Please enter a filename, include .txt in your response: ");
                string fileText = Console.ReadLine();
                Console.WriteLine("Saving to file.... ");
                theJournal.SaveToFile(fileText);
                Console.WriteLine();
            }

            else if (userResponse == "5")
            {
                // Displays a report of the number of entries user has stored in a text file and also displays a list of all the prompts the user has previously used.
                Console.WriteLine("Please enter the filename you want to display a report of: include .txt in your response: ");
                string reportFile = Console.ReadLine();
                
                theJournal.DisplayReport(reportFile);
                Console.WriteLine();
            }

            else if (userResponse == "6")
            {
                // Terminates the program.
                Console.WriteLine("You have chosen to exit program. Goodbye!");
                Console.WriteLine();
                System.Environment.Exit(0);
                continueProgram = false;
            }
        }
        
        
    }
}