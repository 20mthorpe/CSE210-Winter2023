class Cat : Pet
{
    private string _fur;

    public Cat(string fur, string name) //: base(name)
    {
        _fur = fur;
        _name = name;
    }

    public override void DisplayPetInfo()
    {
        System.Console.WriteLine("Your Pet is a Cat!");
        System.Console.WriteLine($"Their name is {_name}.");
        System.Console.WriteLine($"They have {_fur} colored fur.");
    }
}