abstract class Goal
{
    protected int _points;
    protected string _name;
    protected string _desc;
    private bool _isComplete;
    public Goal()
    {

    }
    public string GetName()
    {
        return _name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetDesc()
    {
        return _desc;
    }
    public bool GetComplete()
    {
        return _isComplete;
    }
    public void CompleteEvent()
    {
        _isComplete = true;
    }
    
    public Goal(int points, string name, string description, bool isComplete)
    {
        _points = points;
        _name = name;
        _desc = description;
        _isComplete = isComplete;
    }
    virtual public void DisplayGoal()
    {
        System.Console.WriteLine($"{_name} ({_desc})");
    }

}