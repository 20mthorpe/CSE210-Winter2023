class School
{
    private string _name;
    private string _motto;
    private List<House> _houses;

    public School(string name, string motto, List<House> houses)
    {
        _name = name;
        _motto = motto;
        _houses = houses;
    }
    public void DisplaySchoolInfo()
    {
        int house_amount = _houses.Count();
        System.Console.WriteLine($"The name of our school is {_name}.");
        System.Console.WriteLine($"{_name}'s school motto is {_motto}.");
        System.Console.WriteLine($"{_name} has {house_amount} house(s), they are called: ");
        foreach (House house in _houses)
        {
            System.Console.WriteLine(house.GetHouseName());
        }
    }
    public string GetSchoolName()
    {
        return _name;
    }
    public void DisplayHouseNames()
    {
        int count = 1;
        foreach (House house in _houses)
        {
            System.Console.Write($"{count}. ");
            System.Console.WriteLine(house.GetHouseName());
            count ++;
        }
    }
    //public List<House> GetHouseFromSchool()
    //{
    //    return _houses;
    //}
}