using System;
using System.IO;

public class Journal
{
    List<Entry> JournalEntries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("Display Journal");
        foreach (Entry entry in JournalEntries)
            {
                entry.Display();
            }
        //Console.WriteLine(JournalEntries);
        Console.WriteLine();
    }
    public void AddEntry()
    {
        Console.WriteLine("Add Entry");
        Entry entry1 = new Entry();
        entry1.GetDate();
        entry1.GetName();
        entry1.GetResponse();

        JournalEntries.Add(entry1);
    }

    public void SaveToFile()
    {
        string fileName = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entry in JournalEntries)
            {
                outputFile.WriteLine($"{entry.name},{entry.date},{entry.response}");
            }
        }
    }
    public void LoadFromFile()
    {
        string fileName = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newEntry = new Entry();
            newEntry.name = parts[0];
            newEntry.date = parts[1];
            newEntry.response = parts[2];

            //string loadedLine = Console.ReadLine();
        }
    }
//    public void CreateFile()
//    {
//        if (!System.IO.File.Exists())
//        {
//            File.CreateText();
//        }
//    }

}