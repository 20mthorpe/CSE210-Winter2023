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
        System.Console.WriteLine("What is the Duration of the activity? ");
        string durationString = System.Console.ReadLine();
        int duration = Int32.Parse(durationString);
        _duration = duration;
    }
    public void DisplayStart()
    {
        System.Console.WriteLine("We are now beginning a Mindfulness Activity. ");
    }
    public void DisplayEnd()
    {
        System.Console.WriteLine("We have now concluded a Mindfulness Activity. ");
    }
    public void Pause()
    {

    }
    public void CountdownTimer()
    {

    }
}