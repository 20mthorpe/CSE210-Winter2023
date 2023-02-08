using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        List<string> verses = new List<string>
        {
            "and it came to pass",
            "Jesus Wept",
            "The end."
        };

        Scripture scrip = new Scripture(verses);
        scrip.Display();
        scrip.HideWords(3);
    }
}