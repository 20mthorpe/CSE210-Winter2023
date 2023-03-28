using System;

// EXCEEDING REQUIREMENTS: I only select words that are not already hidden (the requirements say that that can be the stretch)

class Program
{
    static void Main(string[] args)
    {
        Verse mos240 = new Verse("O, all ye old men, and also ye young men, and you little children who can understand my words, for I have spoken plainly unto you that ye might understand, I pray that ye should awake to a remembrance of the awful situation of those that have fallen into transgression.", "Mosiah 2:40");
        Verse mos241 = new Verse("And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.", "Mosiah 2:41");

        List<Verse> verses = new List<Verse>{mos240, mos241};

        Scripture scrip = new Scripture(verses);
        scrip.Display();
        System.Console.Write($"\nClick enter to start hidding words or type quit to exit.");
        string input = System.Console.ReadLine();

        while((!scrip.IsAllHidden()) && (input != "quit"))
        {
            scrip.HideWords(3);
            scrip.Display();
            System.Console.Write($"\nClick enter to clear more words. Type quit to exit. ");
            input = System.Console.ReadLine();
        }
        System.Console.WriteLine("All words have been cleared. ");
    }
    static void ClearConsole(){
        Console.Clear();
    }
}