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
    public void SetPet(Pet pet)
    {
        _pet = pet;
    }
    public void SetWand(Wand wand)
    {
        _wand = wand;
    }
}