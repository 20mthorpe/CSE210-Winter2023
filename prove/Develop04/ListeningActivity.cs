using System;

class ListeningActivity : Activity
{
    private List<string> _items;
    private string _prompt;

    public ListeningActivity(int duration) : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
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