using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        List<string> wordList2 = new List<string>();

        string scriptureText = "And I will also be your light in the wilderness; and I will prepare the way before you, if it so be that ye shall keep my commandments; wherefore, inasmuch as ye shall keep my commandsments ye shall be led towards the promised land; and ye shall know that it is by me that ye are led.";

        string[] words = scriptureText.Split(" ");

        foreach (string word in words)
        {
            wordList2.Add(word);
        }
        
        foreach (string part in wordList2)
        {
            Console.WriteLine(part);
        }

        string userName = "Holly ,Briggs";

         foreach (char i in userName)
        {
            Console.WriteLine(i);
        }

        string hiddenWord = "";

        foreach (char c in userName)
        {
            if (c.Equals(","))
            {
                hiddenWord += c;
            }
            else
            {
                hiddenWord += "_";
            }
        }
        
        Console.WriteLine(userName);
        Console.WriteLine(hiddenWord);

        
    }
}