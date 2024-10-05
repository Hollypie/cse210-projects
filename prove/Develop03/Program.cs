// Author: Holly Briggs, 10/1/2024
// Exceeds Expectations - I have added a couple of features to this program. When the user types "quit", the program is not case sensitive. Also I have added the ability to choose to have words that are blanked out to retain the first letter of the word as a clue. That way as the words disappear the first letter remains and it is easier to recite. The "clue" version of the program should otherwise the same as the normal mode, which is that it ends when all the words in the scripture are hidden or partially blanked out. Also the method that chooses random words to hide, it doesn't select words that were previously hidden.

class Program
{
    static void Main(string[] args)
    {
        // Creates a while loop that repeats program until the continueProgram is set to false.
        bool continueProgram = true;
        while (continueProgram)
        {   
            // instantiates the reference and scripture objects and stores a scripture in the scripture object.
            string scriptureText = "And I will also be your light in the wilderness; and I will prepare the way before you, if it so be that ye shall keep my commandments; wherefore, inasmuch as ye shall keep my commandments ye shall be led towards the promised land; and ye shall know that it is by me that ye are led.";
            Reference reference = new Reference("1 Nephi", 17, 13);
            Scripture scripture = new Scripture(reference, scriptureText);

            // Greets user and inquires which mode the user wants clues or not and formats the answer so it is not case sensitive.
            Console.WriteLine("Welcome the Scripture Memorize Program");
            Console.WriteLine("__________________________________________");
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Would you like to blank out the words completely or leave just the first letter as a clue? Type BLANK or CLUE: ");
            string partialOrFullHide = Console.ReadLine();
            partialOrFullHide = partialOrFullHide.ToUpper();
            
            // While loop to repeat program until all the words are hidden, partially hidden or continueProgram is false.
            while ((!scripture.IsCompletelyHidden() || !scripture.AllWordsPartiallyHidden()) && continueProgram)
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                string userResponse = Console.ReadLine();
                userResponse = userResponse.ToLower();
                
                if (userResponse == "quit")
                {
                    Console.WriteLine("You have chosen to quit. Exiting program... ");
                    continueProgram = false;
                    System.Environment.Exit(0);
                }
                
                Console.Clear();
                if (partialOrFullHide == "CLUE")
                {
                    scripture.PartiallyHideRandomWords(3);
                }
                else
                {
                    scripture.HideRandomWords(3);
                }
                
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();

                // Terminates the program when all of the words are hidden or partially hidden.
                if (scripture.IsCompletelyHidden() || scripture.AllWordsPartiallyHidden())
                {
                    Console.WriteLine("Program ended. Goodbye!");
                    System.Environment.Exit(0);
                }
            }

            
        }
    }
}