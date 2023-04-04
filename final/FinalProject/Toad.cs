class Toad : Pet
{
    private bool _isSpotted;
    public Toad(bool isSpotted, string name)//: base(name)
    {
        _isSpotted = isSpotted;
        _name = name;
    }
    public override void DisplayPetInfo()
    {
        System.Console.WriteLine("Your pet is a Toad");
        System.Console.WriteLine($"Their name is {_name}.");

        if(_isSpotted)
        {
            System.Console.WriteLine("Your toad is spotted. ");
        }
        else
        {
            System.Console.WriteLine("Your toad is not spotted. ");
        }
    }
}