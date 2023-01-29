using System;
using System.IO;

public class Journal
{
    List<string> JournalEntries = new List<string>();

    public void Display()
    {
        Console.WriteLine("Display Journal");
        Console.WriteLine(JournalEntries);
    }
    public void AddEntry()
    {
        Console.WriteLine("Add Entry");
        Entry entry1 = new Entry();
        string date = entry1.GetDate();
        string name = entry1.GetName();
        string response = entry1.GetResponse();

        JournalEntries.Add(date);
        JournalEntries.Add(name);
        JournalEntries.Add(response);
    }

    public void SaveToFile()
    {
        string fileName = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(JournalEntries);
        }
    }
    public void LoadFromFile()
    {
        string fileName = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
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