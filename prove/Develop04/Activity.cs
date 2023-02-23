using System;

class Activity
{
    private string _name = "";
    private string _description = "";
    //private string _welcomeMessage = $"Welcome to the {_name}. ";
    //private string _endMessage = $"You have completed {_duration} seconds of the {_name}";
    private int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void SetDuration()
    {
        System.Console.WriteLine("What is the Duration of the activity (in seconds)? ");
        string durationString = System.Console.ReadLine();
        int duration = Int32.Parse(durationString);
        _duration = duration;
    }
    public void DisplayDiscription()
    {
        System.Console.WriteLine(_description);
    }
    public void DisplayStart()
    {
        System.Console.WriteLine($"Welcome to the {_name}. ");
        //System.Console.WriteLine(_welcomeMessage);
    }
    public void DisplayEnd()
    {
        System.Console.WriteLine("Well done! ");
        System.Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        //System.Console.WriteLine(_endMessage);
    }
    public void Pause()
    {

    }
    public void CountdownTimer()
    {

    }
}