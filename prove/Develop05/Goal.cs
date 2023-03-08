class Goal
{
    private int _points;
    private string _name;
    private string _desc;
    private bool _isComplete;
    public Goal()
    {

    }
    public Goal(int points, string name, string description, bool isComplete)
    {
        _points = points;
        _name = name;
        _desc = description;
        _isComplete = isComplete;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetDescription(string desc)
    {
        _desc = desc;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void SetCompetion(bool isComplete)
    {
        _isComplete = isComplete;
    }
}