class House
{
    private string _name;
    private List<string> _values;
    private List<string> _colors;
    private string _mascot;
    private string _commonRoomEntrance;

    public House(string name, string mascot, string commonRoomEntrance, List<string> values, List<string> colors)
    {
        _name = name;
        _mascot = mascot;
        _commonRoomEntrance = commonRoomEntrance;
        _values = values;
        _colors = colors;
    }

}