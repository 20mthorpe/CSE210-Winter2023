
using System;
class Entry
{

    List<string> _entries = new List<string>();
    public string GetDate()
    {
        Console.Write("What is the date? ");
        string date = Console.ReadLine();
        _entries.Add(date);
        return date;
    }
    public string GetName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine(); 
        _entries.Add(name);
        return name;
    }
    public string GetResponse()
    {
        Prompt prompt1 = new Prompt();
        prompt1.DisplayRandomPrompt();
        string writtenEntry = Console.ReadLine();
        _entries.Add(writtenEntry);
        return writtenEntry;
    }
    public void Display()
    {
        Console.WriteLine(_entries);
    }

}