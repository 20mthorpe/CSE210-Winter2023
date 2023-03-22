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
}