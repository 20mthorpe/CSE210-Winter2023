class Owl:Pet
{
    private string _feathers;
    public Owl(string name, string feathers)//: base(name)
    {
        _feathers = feathers;
        _name = name;
    }

    public override void DisplayPetInfo()
    {
        System.Console.WriteLine("Your pet is an Owl!");
        System.Console.WriteLine($"Their name is {_name}.");
        System.Console.WriteLine($"Their feathers are {_feathers}.");
    }
}