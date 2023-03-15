class ChecklistGoal : Goal
{

    public int _numToCompletion = 0;
    public int _bonusPoints = 0;
    public int _timesCompleted = 0;
    public ChecklistGoal(int points, string name, string desc, bool isComplete, int numToCompletion, int bonusPoints) : base(points, name, desc, isComplete)
    {
        _numToCompletion = numToCompletion;
        _bonusPoints = bonusPoints;
    }
    public override void DisplayGoal()
    {
        System.Console.WriteLine($"{_name} ({_desc}) -- Currently Completed {_timesCompleted}/{_numToCompletion}");
    }
    public void CompleteEventOnce()
    {
        _timesCompleted++;
    }
}