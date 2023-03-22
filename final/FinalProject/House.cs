class House
{
    private string _name;
    private List<string> _values;
    private List<string> _colors;
    private string _mascot;
    private string _commonRoomEntrance;
    private string _ghost;
    private string _founder;

    public House(string name, string mascot, string commonRoomEntrance, List<string> values, List<string> colors, string ghost, string founder)
    {
        _name = name;
        _mascot = mascot;
        _commonRoomEntrance = commonRoomEntrance;
        _values = values;
        _colors = colors;
        _ghost = ghost;
        _founder = founder;
    }

}