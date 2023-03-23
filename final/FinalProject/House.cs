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

    public void DisplayHouseInfo()
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"The house you are in is {_name}.");
        System.Console.WriteLine($"{_name} very highly values the traits of {_values[0]} and {_values[1]}.");
        System.Console.WriteLine($"The {_name} House colors are {_colors[0]} and {_colors[1]}.");
        System.Console.WriteLine($"The mascot for the {_name} House is a {_mascot}.");
        System.Console.WriteLine($"Your common room can be found through a {_commonRoomEntrance}.");
        System.Console.WriteLine($"The founder of the {_name} house was {_founder}.");
        System.Console.WriteLine($"You also have a house ghost! They go by the title of {_ghost}.");
        System.Console.WriteLine($"There's a brief summary of the {_name} house!");
        System.Console.WriteLine();
    }
    public string GetHouseName()
    {
        return _name;
    }

}