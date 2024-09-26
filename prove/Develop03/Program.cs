using System;

class Program
{
    static void Main(string[] args)
    {
        VerseReference reference1 = new VerseReference("1 Nephi", "17", "13");
        Scripture scripture1 = new Scripture();
        string scriptureText = "And I will also be your light in the wilderness; and I will prepare the way before you, if it so be that ye shall keep my commandments; wherefore, inasmuch as ye shall keep my commandsments ye shall be led towards the promised land; and ye shall know that it is by me that ye are led.";
        Console.WriteLine(reference1.DisplayReference());
        scripture1.AddScripture(scriptureText);
        scripture1.DisplayScripture();
    }
}