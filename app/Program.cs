// See https://aka.ms/new-console-template for more information

Random randomGenerator = new Random();
int number = randomGenerator.Next(1,101);
Console.WriteLine(number);
List<string> verses = new List<string>
        {
            "and it came to pass",
            "Jesus Wept",
            "The end."
        };
        Console.Write(verses[1]);

        Scripture scrip = new Scripture();
        scrip.Scriptures(verses);
        scrip.Display();