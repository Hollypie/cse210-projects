// Author: Holly Briggs, 10/1/2024
// Exceeds Expectations - I have added a couple of features to this program. When the user types "quit", the program is not case sensitive. Also I have added the ability to choose to have words that are blanked out to retain the first letter of the word as a clue. That way as the words disappear the first letter remains and it is easier to recite. The "clue" version of the program should otherwise the same as the normal mode, which is that it ends when all the words in the scripture are hidden or partially blanked out.

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            string scriptureText = "And I will also be your light in the wilderness; and I will prepare the way before you, if it so be that ye shall keep my commandments; wherefore, inasmuch as ye shall keep my commandments ye shall be led towards the promised land; and ye shall know that it is by me that ye are led.";
            Reference reference = new Reference("1 Nephi", 17, 13);
            Scripture scripture = new Scripture(reference, scriptureText);

            Console.WriteLine("Welcome the Scripture Memorize Program");
            Console.WriteLine("__________________________________________");
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Would you like to blank out the words completely or leave just the first letter as a clue? Type BLANK or CLUE: ");
            
            string partialOrFullHide = Console.ReadLine();
            partialOrFullHide = partialOrFullHide.ToUpper();
            

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

                if (scripture.IsCompletelyHidden() || scripture.AllWordsPartiallyHidden())
                {
                    Console.WriteLine("Program ended. Goodbye!");
                    System.Environment.Exit(0);
                }
            }

            
        }
    }
}