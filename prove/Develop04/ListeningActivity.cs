using System;

class ListeningActivity : Activity
{
    private List<string> _items;
    private string _prompt;

    public ListeningActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void GetRandomPrompt()
    {
        _prompt = ("Here is a random prompt for now");
    }
    public void GetItems()
    {

    }
    public void DisplayItemAmount()
    {
        System.Console.WriteLine(_items.Count);
    }

}