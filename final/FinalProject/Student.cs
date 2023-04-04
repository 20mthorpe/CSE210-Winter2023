class Student
{
    private string _name;
    private int _year;
    private House _house;
    private Pet _pet;
    private Wand _wand;

    public Student(string name, int year, House house)
    {
        _name = name;
        _year = year;
        _house = house;
    }
    public House GetHouse()
    {
        return _house;
    }
    public void SetPet(Pet pet)
    {
        _pet = pet;
    }
    public Pet GetPet()
    {
        return _pet;
    }
    public void SetWand(Wand wand)
    {
        _wand = wand;
    }
    public void DisplayStudentInfo()
    {
        System.Console.WriteLine($"Your name is {_name}");

        if(_year == 1)
        {
            System.Console.WriteLine($"You are in your first year.");
        }
        else if(_year == 2)
        {
            System.Console.WriteLine($"You are in your second year.");
        }
        else if(_year == 3)
        {
            System.Console.WriteLine($"You are in your third year.");
        }
        else if(_year == 4)
        {
            System.Console.WriteLine($"You are in your fourth year.");
        }
        else if(_year == 5)
        {
            System.Console.WriteLine($"You are in your fifth year.");
        }
        else if(_year == 6)
        {
            System.Console.WriteLine($"You are in your sixth year.");
        }
        else if(_year == 7)
        {
            System.Console.WriteLine($"You are in your seventh year.");
        }
        
    }
}