using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public void SetDuration()
    {
        System.Console.WriteLine("What is the Duration of the activity? ");
        string durationString = System.Console.ReadLine();
        int duration = Int32.Parse(durationString);
        _duration = duration;
    }

    public void DisplayStart()
    {

    }
    public void DisplayEnd()
    {

    }
    public void Pause()
    {

    }
    public void CountdownTimer()
    {

    }
}