
using System;
class Entry
{
    public string name;
    public string date;
    public string response;
    public void GetDate()
    {
        Console.Write("What is the date? ");
        date = Console.ReadLine();
    }
    public void GetName()
    {
        Console.Write("What is your name? ");
        name = Console.ReadLine(); 
    }
    public void GetResponse()
    {
        Prompt prompt1 = new Prompt();
        prompt1.DisplayRandomPrompt();
        response = Console.ReadLine();
        
    }
    public void Display()
    {
        Console.WriteLine(name);
        Console.WriteLine(date);
        Console.WriteLine(response); 
    }

}