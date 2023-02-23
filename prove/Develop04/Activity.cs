using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

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
    }
    public void DisplayEnd()
    {
        System.Console.WriteLine("Well done! ");
        System.Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
    }
    public void Pause()
    {

    }
    public void CountdownTimer()
    {

    }
}